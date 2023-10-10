using CinemaWebApi.CQRS.Commands.CinemaCommand;
using CinemaWebApi.CQRS.Queries.CinemaQuery;
using CinemaWebApi.DB;
using CinemaWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemaWebApi.Controllers
{
    [Route("api/[controller]")]
    public class CinemaController : ControllerBase
    {
        private readonly ICinemaDbContext _db;
        public CinemaController(ICinemaDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult> GetList()
        {
            return Ok(await GetCinemaList.Get(_db));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {
            
            return Ok(await GetCinema.Get(id, _db));
        }

        [HttpPost]
        public async Task<ActionResult> Post(
            [FromBody] Cinema cinema)
        {
            
            return Ok(await CreateCinema.Create(cinema, _db));
        }
    }
}
