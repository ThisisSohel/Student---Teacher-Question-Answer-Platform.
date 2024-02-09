using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;
using Teacher_Student_platform.Models;
using Teacher_Student_platform.Models.Entities;
using Teacher_Student_platform.Web.Data;

namespace Teacher_Student_platform.Controllers
{
    public class QueAnsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public QueAnsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddQuesAnsViewModel viewModel)
        {
            var queAns = new quesAns
            {
                Name = viewModel.Name,
                Email = viewModel.Email,
                Question = viewModel.Question,
                Answer = viewModel.Answer
            };
            await dbContext.quesAnses.AddAsync(queAns);
            await dbContext.SaveChangesAsync();
            return View();
        }

        [HttpGet]

        public async Task<IActionResult> List()
        {
            var queenses = await dbContext.quesAnses.ToListAsync();
            return View(queenses);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var qusans = await dbContext.quesAnses.FindAsync(id);

            return View(qusans);
             
        }


        [HttpPost]
        public async Task<IActionResult> Edit(quesAns viewModel)
        {
            var qusans1 = await dbContext.quesAnses.FindAsync(viewModel.Id);

            if(qusans1 is not null)
            {
                qusans1.Name = viewModel.Name;
                qusans1.Email = viewModel.Email;
                qusans1.Question = viewModel.Question;
                qusans1.Answer = viewModel.Answer;


                await dbContext.SaveChangesAsync();

            }
            return RedirectToAction("List", "QueAns");
        }

        [HttpPost]

        public async Task<IActionResult> Delete(quesAns viewModel)
        {
            var qusans1 = await dbContext.quesAnses
                .AsNoTracking()
                .FirstOrDefaultAsync(x => x.Id == viewModel.Id);
            if(qusans1 is not null)
            {
                dbContext.quesAnses.Remove(viewModel);
                await dbContext.SaveChangesAsync();
            }

            return RedirectToAction("List", "QueAns");
        }

    }
}
