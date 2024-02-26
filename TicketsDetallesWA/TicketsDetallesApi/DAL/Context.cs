using Microsoft.EntityFrameworkCore;
using BibliotecaModels.Models;

namespace TicketsDetallesApi.Server.DAL
{ 
    public class Context : DbContext 
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Tickets> Tickets { get; set; }
        public DbSet<TicketsDetalles> TicketsDetalle { get; set; }
        public DbSet<Prioridades> Prioridades { get; set; }
        public DbSet<Sistema> Sistema { get; set; }
    }
}
