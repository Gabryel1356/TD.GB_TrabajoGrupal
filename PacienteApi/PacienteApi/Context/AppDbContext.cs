using Microsoft.EntityFrameworkCore;
using PacienteApi.Models;

namespace PacienteApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }
        public DbSet<Paciente> Pacientes { get; set; }
    }
}
