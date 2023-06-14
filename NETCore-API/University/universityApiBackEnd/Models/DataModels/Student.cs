using System.ComponentModel.DataAnnotations;

namespace universityApiBackEnd.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Microsoft.Build.Framework.Required]
        public string FirstName { get; set; } = string.Empty;

        [Microsoft.Build.Framework.Required]
        public string LastName { get; set; } = string.Empty;

        [Microsoft.Build.Framework.Required]
        public DateTime Dob { get; set; }

        public ICollection<Course> Courses { get; set; }


    }
}
