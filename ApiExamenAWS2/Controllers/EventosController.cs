using ApiExamenAWS2.Models;
using ApiExamenAWS2.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiExamenAWS2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private RepositoryEventos repo;

        public EventosController(RepositoryEventos repo)
        {
            this.repo = repo;
        }

        [HttpGet("eventos")]
        public async Task<ActionResult<List<EventoExamen>>>
            Get()
        {
            return await this.repo.GetEventosAsync();
        }
        [HttpGet]
        public async Task<ActionResult<List<CategoriaEventos>>>
            GetCategorias()
        {
            return await this.repo.GetCategoriasAsync();
        }

        [HttpGet]
        [Route("[action]/{id}")]
        public async Task<ActionResult<List<EventoExamen>>>
           FindEventos(int id)
        {
            return await this.repo.GetEventosPorCategoriaAsync(id);
        }
    }
}
