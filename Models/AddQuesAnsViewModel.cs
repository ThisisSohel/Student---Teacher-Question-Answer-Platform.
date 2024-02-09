namespace Teacher_Student_platform.Models
{
    public class AddQuesAnsViewModel
    {

        public string Name { get; set; }
      
        public string Email { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; } // Make Answer property optional
    }
}
