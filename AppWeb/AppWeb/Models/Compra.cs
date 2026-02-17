using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppWeb.Models
{
    public class Compra
    {
        [Key]
        public int id { get; set; }
        [Required]
        public DateTime FechaCompra { get; set; } = DateTime.Now;
        [Required]
        public int UsuarioId { get; set; }

        [ForeignKey("UsuarioId")]
        public Usuario Usuario { get; set; }

        public int VideojuegosId { get; set; }

        [ForeignKey("VideojuegosId")]
        public Videojuegos Videojuegos { get; set; }
    }
}
