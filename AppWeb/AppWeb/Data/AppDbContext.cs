using AppWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace AppWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Videojuegos> Videojuegos { get; set; }
        public DbSet<Compra> compras { get; set; }
    }
}
