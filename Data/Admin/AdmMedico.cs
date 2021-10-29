using Datos.Data;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Admin
{
    public static class AdmMedico
    {
        static DbClinicaContext context = new DbClinicaContext();
        public static List<Medico> Listar()
        {
            return context.Medicos.ToList();
        }

        public static List<Medico> Listar(int especialidadId)
        {
            List<Medico> medicos = (from m in context.Medicos
                                    where m.EspecialidadId == especialidadId
                                    select m).ToList();
            return medicos;

        }

        public static Medico TraerPorId(int id)
        {
            return context.Medicos.Find(id);
        }

        public static int Insertar(Medico medico)
        {
            context.Medicos.Add(medico);
            return (context.SaveChanges());
        }

        public static int Modificar(Medico medico)
        {
            Medico medicoOrigen = context.Medicos.Find(medico.MedicoId);

            if (medicoOrigen != null)
            {
                medicoOrigen.Nombre = medico.Nombre;
                medicoOrigen.Apellido = medico.Apellido;
                medicoOrigen.Matricula = medico.Matricula;
                medicoOrigen.EspecialidadId = medico.EspecialidadId;

                return context.SaveChanges();
            }
            return 0;

        }
        public static int Eliminar(int id)
        {
            Medico medicoOrigen = context.Medicos.Find(id);
            if (medicoOrigen != null)
            {
                context.Medicos.Remove(medicoOrigen);
                return context.SaveChanges();
            }
            return 0;
        }
    }
}
