using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Models
{
    [Table("Medico")]
    public class Medico
    {
        public int MedicoId { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Apellido { get; set; }


        public int Matricula { get; set; }

        public List<Paciente> pacientes { get; set; }

        public int EspecialidadId { get; set; }//FK


        [ForeignKey("EspecialidadId")]
        public Especialidad Especialidad { get; set; }
    }
}
