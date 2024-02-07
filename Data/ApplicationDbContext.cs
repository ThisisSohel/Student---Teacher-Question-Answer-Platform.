using Microsoft.EntityFrameworkCore;
using Teacher_Student_platform.Models.Entities;

namespace Teacher_Student_platform.Web.Data {
    

    public class ApplicationDbContext: DbContext{
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }

        public DbSet<quesAns> quesAnses { get; set; }

    }
}
