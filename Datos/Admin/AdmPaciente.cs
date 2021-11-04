using Datos.Data;
using Datos.Models;
using System.Collections.Generic;
using System.Linq;

namespace Datos.Admin
{
    public static class AdmPaciente
    {

        static DbClinicaContext context = new DbClinicaContext();
        public static List<Paciente> Listar()
        {
            return context.Pacientes.ToList();
        }

        public static Paciente TraerPorId(int id)
        {
            return context.Pacientes.Find(id);
        }

        public static int Insertar(Paciente paciente)
        {
            context.Pacientes.Add(paciente);
            return (context.SaveChanges());
        }

        public static int Modificar(Paciente paciente)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(paciente.Id);

            if (pacienteOrigen != null)
            {
                pacienteOrigen.Nombre = paciente.Nombre;
                pacienteOrigen.Apellido = paciente.Apellido;
                pacienteOrigen.FechaNacimiento = paciente.FechaNacimiento;
                pacienteOrigen.NroHistoriaClinica = paciente.NroHistoriaClinica;
                pacienteOrigen.MedicoId = paciente.MedicoId;

                return context.SaveChanges();
            }
            return 0;

        }
        public static int Eliminar(int id)
        {
            Paciente pacienteOrigen = context.Pacientes.Find(id);
            if (pacienteOrigen != null)
            {
                context.Pacientes.Remove(pacienteOrigen);
                return context.SaveChanges();
            }
            return 0;
        }
    }
}
