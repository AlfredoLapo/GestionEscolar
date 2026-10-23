using Microsoft.EntityFrameworkCore;
using GestionEscolar.Models;

namespace GestionEscolar.Data
{
    public class GestionEscolarContext : DbContext
    {
        public DbSet<GestionEscolar.Models.Aula> Aula { get; set; } = default!;
        public DbSet<GestionEscolar.Models.Maestro> Maestro { get; set; } = default!;
        public GestionEscolarContext(DbContextOptions<GestionEscolarContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiante { get; set; }
    }
}
