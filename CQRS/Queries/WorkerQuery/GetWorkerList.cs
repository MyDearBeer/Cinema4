using CinemaWebApi.DB;
using CinemaWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApi.CQRS.Queries.WorkerQuery
{
    public class GetWorkerList
    {
        public static async Task<List<Worker>> Get(ICinemaDbContext dbContext)
        {
            return await dbContext.Workers.ToListAsync();
        }
    }
}
