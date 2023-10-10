using CinemaWebApi.DB;
using CinemaWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApi.CQRS.Queries.WorkerQuery
{
    public class GetWorker
    {
        public static async Task<Worker> Get(Guid id, ICinemaDbContext dbContext)
        {
            return await dbContext.Workers.FirstOrDefaultAsync(w => w.Id == id);
        }
    }
}
