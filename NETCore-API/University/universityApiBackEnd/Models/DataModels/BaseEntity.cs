using System.ComponentModel.DataAnnotations;

namespace universityApiBackEnd.Models.DataModels
{
    public class BaseEntity
    {
        [Required] //requerido
        [Key]   //clave unica (estops 2 parametros apuntan a la variable que sigue)
        public int Id { get; set; }
        public string CreatedBy { get; set; } = String.Empty;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = String.Empty;
        public DateTime? UpdatedAt { get; set; }
        public string deletedBy { get; set; } = String.Empty;
        public DateTime? deletedAt { get; set; }
        public bool IsDeleted { get; set; } = false;

    }
}
