using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AppWeb.Models
{
    public class Videojuegos
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string titulo { get; set; }

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal precio { get; set; }

        [Required]
        public string categoria { get; set; }

        [Required]
        public string descripcion { get; set; }

        public ICollection<Compra> Compras { get; set; }
    }
}
