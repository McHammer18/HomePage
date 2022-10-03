using System.ComponentModel.DataAnnotations;

namespace HomePage.Models
{
    public class StudentModel
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Grade { get; set; }
    }
}
