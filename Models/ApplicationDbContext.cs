using Microsoft.EntityFrameworkCore;


namespace examenDAW.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Materie> Materii { get; set; }

        public DbSet<Profesor> Profesori { get; set; }

        public DbSet<MateriiProfesori> MateriiProfi { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // legatura many to many

            modelBuilder.Entity<MateriiProfesori>()
            .HasKey(up => new
            {
                up.Id,
                up.ProfesorId,
                up.MaterieId
            });

            modelBuilder.Entity<MateriiProfesori>()
            .HasOne(up => up.Prof)
            .WithMany(up => up.Materii)
            .HasForeignKey(up => up.ProfesorId);

            modelBuilder.Entity<MateriiProfesori>()
            .HasOne(up => up.Mat)
            .WithMany(up => up.Profesori)
            .HasForeignKey(up => up.MaterieId);
        }
    }
}