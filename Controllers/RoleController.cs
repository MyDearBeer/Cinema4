using CinemaWebApi.CQRS.Commands.RoleCommand;
using CinemaWebApi.CQRS.Queries.RoleQuery;
using CinemaWebApi.DB;
using CinemaWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemaWebApi.Controllers
{
    [Route("api/[controller]")]
    public class RoleController : ControllerBase
    {
        private readonly ICinemaDbContext _db;
        public RoleController(ICinemaDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult> GetList()
        {
            return Ok(await GetRoleList.Get(_db));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {

            return Ok(await GetRole.Get(id, _db));
        }

        [HttpPost]
        public async Task<ActionResult> Post(
            [FromBody] Role role)
        {

            return Ok(await CreateRole.Create(role, _db));
        }
    }
}
