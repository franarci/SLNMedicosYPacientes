using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Datos.Models;
namespace Datos.Data
{
    public class DbClinicaContext : DbContext
    {
        public DbSet<Paciente> Pacientes { get; set; }
        //public DbSet<Habitacion> habitaciones { get; set; }
        public DbSet<Medico> Medicos { get; set; }

        public DbSet<Especialidad> Especialidades { get; set; }

        public DbClinicaContext(): base("KeyDbClinica") { }
    }
}
