using System.ComponentModel.DataAnnotations;

namespace AppWeb.Models
{
    public class Usuario
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string nombre { get; set; }

        [Required]
        public string correo { get; set; }

        [Required]
        public string password { get; set; }

        [Required]
        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public ICollection<Compra> Compras{ get; set; }
    }
}
