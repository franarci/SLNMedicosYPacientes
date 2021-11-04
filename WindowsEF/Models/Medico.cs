using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEF.Models
{
    public class Medico
    {
        public int MedicoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Matricula { get; set; }

        public List<Paciente> pacientes { get; set; }



        public int EspecialidadId { get; set; }//FK

        //navegacion
        [ForeignKey("EspecialidadId")]
        public Especialidad Especialidad { get; set; }
    }
}
