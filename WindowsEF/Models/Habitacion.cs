using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEF.Models
{
    [Table("Habitacion")]
    public class Habitacion
    {
        [Key]
        public int IdHabitacion { get; set; }

        public int Numero { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(12)]
        public string Estado { get; set; }

        public int ClinicaId { get; set; }//FK

        //navegacion
        [ForeignKey("ClinicaId")]
        public Clinica Clinica { get; set; }
    }
}
