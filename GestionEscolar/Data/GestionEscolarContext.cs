using Microsoft.EntityFrameworkCore;
using GestionEscolar.Models;

namespace GestionEscolar.Data
{
    public class GestionEscolarContext : DbContext
    {
        public GestionEscolarContext(DbContextOptions<GestionEscolarContext> options)
            : base(options)
        {
        }

        public DbSet<Estudiante> Estudiante { get; set; }
    }
}
