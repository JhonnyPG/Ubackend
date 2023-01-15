using Microsoft.EntityFrameworkCore;
using Ubackend.Models;

namespace Ubackend.Data
{
    public class UbackendDbContext : DbContext
    {
        public UbackendDbContext(DbContextOptions<UbackendDbContext> options) : base(options)
        {
        }
        
        public DbSet<User>? Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Curso>? Cursos { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<Chapter>? Chapters { get; set; }
    }
}
