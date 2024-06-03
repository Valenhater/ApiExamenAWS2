using ApiExamenAWS2.Data;
using ApiExamenAWS2.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiExamenAWS2.Repositories
{
    public class RepositoryEventos
    {
        private EventosContext context;

        public RepositoryEventos(EventosContext context)
        {
            this.context = context;
        }
        public async Task<List<CategoriaEventos>> GetCategoriasAsync()
        {
            return await this.context.Categorias.ToListAsync();
        }

        public async Task<List<EventoExamen>> GetEventosAsync()
        {
            return await this.context.Eventos.ToListAsync();
        }
        public async Task<List<EventoExamen>> GetEventosPorCategoriaAsync(int id)
        {
            return await this.context.Eventos
                                     .Where(x => x.IdCategoria == id)
                                     .ToListAsync();
        }
    }
}
