using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Teacher_Student_platform.Models;
using Teacher_Student_platform.Models.Entities;

namespace Teacher_Student_platform.Web.Data
{


    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<quesAns> quesAnses { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var student = new IdentityRole("student");
            student.NormalizedName = "student";

            var teacher = new IdentityRole("teacher");
            teacher.NormalizedName = "teacher";

            var moderator = new IdentityRole("moderator");
            moderator.NormalizedName = "moderator";

            builder.Entity<IdentityRole>().HasData(student, teacher, moderator);
        }

    }
}
