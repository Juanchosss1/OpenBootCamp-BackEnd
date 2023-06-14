using System.ComponentModel.DataAnnotations;

namespace universityApiBackEnd.Models.DataModels
{
    public class Category : BaseEntity
    {
        [Microsoft.Build.Framework.Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        public ICollection<Course> Courses { get; set; } = new List<Course>(); 
    }
}
