using System.Data.Entity;
using WindowsEF.Models;
namespace WindowsEF.Data
{
    public class DbClinicaContext : DbContext
    {
        public DbSet<Paciente> pacientes { get; set; }
        public DbSet<Habitacion> habitaciones { get; set; }

        public DbClinicaContext() : base("KeyDbClinica") { }
    }
}
