using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace universityApiBackEnd.Models.DataModels
{
    public enum Level
    {
        Basic,
        Medium,
        Advanced,
        Expert
    }
    public class Course : BaseEntity
    {
        [Microsoft.Build.Framework.Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;

        [Microsoft.Build.Framework.Required, StringLength(280)]
        public string ShortDescription { get; set; } = string.Empty;

        [Microsoft.Build.Framework.Required]
        public string Description { get; set; } = string.Empty;

        public Level Level { get; set; } = Level.Basic;

        [Microsoft.Build.Framework.Required]
        public ICollection<Category> Categories { get; set; } = new List<Category>();

        [Microsoft.Build.Framework.Required]
        public Chapter Index { get; set; } = new Chapter();

        [Microsoft.Build.Framework.Required]
        public ICollection<Student> Students { get; set; } = new List<Student>();

    }
}
