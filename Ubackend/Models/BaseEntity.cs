using System.ComponentModel.DataAnnotations;

namespace Ubackend.Models
{
    public class BaseEntity
    {
        [Required]
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreateAt { get; set; } = DateTime.Now;
        public string UpdatedBy { get; set; } = string.Empty;
        public DateTime? UpdateAt { get; set; }  
        public string DeletedBy { get; set; } = string.Empty;
        public string? DeletedAt { get; set; }
        public Boolean IsDeleted { get; set; } = false;
    }
}
