using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Models
{
    [Table("Paciente")]
    public class Paciente
    {
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Apellido { get; set; }

        [Column(TypeName = "date")]
        public DateTime FechaNacimiento { get; set; }
        public int NroHistoriaClinica { get; set; }

        public int MedicoId { get; set; }//FK

        //navegacion
        [ForeignKey("MedicoId")]
        public Medico Medico { get; set; }
    }
}
