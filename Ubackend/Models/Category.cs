using System.ComponentModel.DataAnnotations;

namespace Ubackend.Models
{
    public class Category : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public ICollection<Curso> Cursos { get; set; } = new List<Curso>();

    }
}
