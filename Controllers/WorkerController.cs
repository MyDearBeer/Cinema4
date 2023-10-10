using CinemaWebApi.CQRS.Commands.WorkerCommand;
using CinemaWebApi.CQRS.Queries.WorkerQuery;
using CinemaWebApi.DB;
using CinemaWebApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CinemaWebApi.Controllers
{
    [Route("api/[controller]")]
    public class WorkerController : ControllerBase
    {
        private readonly ICinemaDbContext _db;
        public WorkerController(ICinemaDbContext db)
        {
            _db = db;
        }

        [HttpGet]
        public async Task<ActionResult> GetList()
        {
            return Ok(await GetWorkerList.Get(_db));
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(Guid id)
        {

            return Ok(await GetWorker.Get(id, _db));
        }

        [HttpPost]
        public async Task<ActionResult> Post(
            [FromBody] Worker worker)
        {

            return Ok(await CreateWorker.Create(worker, _db));
        }
    }
}
