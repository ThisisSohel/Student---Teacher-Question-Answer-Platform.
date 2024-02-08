using System;

namespace Teacher_Student_platform.Models.Entities
{
    public class quesAns
    {
        public Guid Id  { get; set; }
        public string Name { get; set; }
        public string Ques { get; set; }
        public string Email { get; set; } 
        public string Answer { get; set; } // Add this property for the answer
    }
}
