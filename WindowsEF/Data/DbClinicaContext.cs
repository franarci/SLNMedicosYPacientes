using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WindowsEF.Models;
namespace WindowsEF.Data
{
    public class DbClinicaContext : DbContext
    {
        public DbSet<Paciente> pacientes { get; set; }
        public DbSet<Habitacion> habitaciones { get; set; }

        public DbClinicaContext(): base("KeyDbClinica") { }
    }
}
