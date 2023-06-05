using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations;

namespace universityApiBackEnd.Models.DataModels
{
    public class Curso:BaseEntity
    {
        [System.ComponentModel.DataAnnotations.Required, StringLength(280)]
        public string Name { get; set; } = string.Empty;
        [System.ComponentModel.DataAnnotations.Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;
        [System.ComponentModel.DataAnnotations.Required]
        public string DescripcionLarga { get; set; } = string.Empty;
        public string PublicoObjetivo { get; set; }
        public string Objetivos { get; set; }
        public string Requisitos { get; set; }
        public enum Nivel {Basico, Intermedio, Avanzado }

    }
}
