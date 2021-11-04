using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WindowsEF.Models
{
    [Table("Especialidad")]
    public class Especialidad
    {
        public int Id { get; set; }

        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string Nombre { get; set; }
    }
}
