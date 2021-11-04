using Datos.Models;
using System.Data.Entity;
namespace Datos.Data
{
    public class DbClinicaContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        //public DbSet<Habitacion> habitaciones { get; set; }
        public DbSet<Medico> Medicos { get; set; }

        public DbSet<Especialidad> Especialidades { get; set; }

        public DbClinicaContext() : base("KeyDbClinica") { }
    }
}
