using System.ComponentModel.DataAnnotations;

namespace Ubackend.Models
{
    public class Chapter : BaseEntity
    {
        public int CursoId { get; set; }
        public virtual Curso Curso { get; set; } = new Curso();    
        [Required]
        public string List = String.Empty;

    }
}
