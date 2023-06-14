using Microsoft.EntityFrameworkCore;
using universityApiBackEnd.Models.DataModels;

namespace universityApiBackEnd.DataAccess
{
    public class UniversityDBContext : DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options) : base(options) { }
    
        
        //Desde aca, agregamos las tablas de la DB

    public DbSet<User>? Users { get; set; } //esto va a crear las tablas en la base de datos
    public DbSet<Course>? Courses { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Chapter>? Chapters { get; set; }
    public DbSet<Student>? Students { get; set; }

    }

}
