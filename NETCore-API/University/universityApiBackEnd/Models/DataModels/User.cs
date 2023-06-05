using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace universityApiBackEnd.Models.DataModels
{
    public class User : BaseEntity //extendemos a la base que hicimos antes, asi tiene todos los paramtreos de esa base
    {
        [System.ComponentModel.DataAnnotations.Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [System.ComponentModel.DataAnnotations.Required, StringLength(100)]
        public string LastName { get; set; } = string.Empty;
        [System.ComponentModel.DataAnnotations.Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [System.ComponentModel.DataAnnotations.Required]
        public string Password { get; set; } = string.Empty;
    }
}
