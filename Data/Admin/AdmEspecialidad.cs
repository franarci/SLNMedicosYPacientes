using Datos.Data;
using Datos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Admin
{
    public static class AdmEspecialidad
    {
        static DbClinicaContext context = new DbClinicaContext();
        public static List<Especialidad> Listar()
        {
            return context.Especialidades.ToList();
        }

        public static Especialidad TraerPorId(int id)
        {
            return context.Especialidades.Find(id);
        }

        public static int Insertar(Especialidad Especialidad)
        {
            context.Especialidades.Add(Especialidad);
            return (context.SaveChanges());
        }

        public static int Modificar(Especialidad especialidad)
        {
            Especialidad EspecialidadOrigen = context.Especialidades.Find(especialidad.Id);

            if (EspecialidadOrigen != null)
            {
                EspecialidadOrigen.Nombre = especialidad.Nombre;

                return context.SaveChanges();
            }
            return 0;

        }
        public static int Eliminar(int id)
        {
            Especialidad EspecialidadOrigen = context.Especialidades.Find(id);
            if (EspecialidadOrigen != null)
            {
                context.Especialidades.Remove(EspecialidadOrigen);
                return context.SaveChanges();
            }
            return 0;
        }
    }
}
