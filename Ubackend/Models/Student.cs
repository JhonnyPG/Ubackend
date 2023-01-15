using System.ComponentModel.DataAnnotations;

namespace Ubackend.Models
{
    public class Student : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime Dob { get; set; }

       
        public ICollection<Curso>? Cursos { get; set; } = new List<Curso>();
    }
}
