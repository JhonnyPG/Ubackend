using System.ComponentModel.DataAnnotations;
using Ubackend.Models.Enums;

namespace Ubackend.Models
{
    public class Curso : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string DescripcionCorta { get; set; } = string.Empty;
        [Required]
        public string DescriptcionLarga { get; set; } = string.Empty;
        [Required]
        public string PublicoObjetivo { get; set; } = string.Empty;
        [Required]
        public string Objetivo { get; set; } = string.Empty;
        [Required]
        public string Requisitos  { get; set; } = string.Empty;
        public NivelEnum NivelEnum { get; set; } = NivelEnum.Basico;

        [Required]
        public ICollection<Category> Categories { get; set; } = new List <Category>();
        [Required]
        public ICollection<Student> Students { get; set; } = new List <Student>();
        [Required]
        public Chapter Chapter { get; set; } = new Chapter();
       



    }
}
;