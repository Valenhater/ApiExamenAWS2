using ApiExamenAWS2.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiExamenAWS2.Data
{
    public class EventosContext :DbContext
    {
        public EventosContext(DbContextOptions<EventosContext> options)
            : base(options) { }
        public DbSet<EventoExamen> Eventos { get; set; }
        public DbSet<CategoriaEventos> Categorias { get; set; }
    }
}
