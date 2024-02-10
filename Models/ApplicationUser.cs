using Microsoft.AspNetCore.Identity;
using System.Data;

namespace Teacher_Student_platform.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; } = "";
        public string EmailAddress { get; set; } = "";
        public DataSetDateTime CreateedAt { get; set; }


    }
}
