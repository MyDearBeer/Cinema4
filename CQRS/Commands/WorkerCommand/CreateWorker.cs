using CinemaWebApi.DB;
using CinemaWebApi.Models;

namespace CinemaWebApi.CQRS.Commands.WorkerCommand
{
    public class CreateWorker
    {
        public static async Task<Guid> Create(Worker request, ICinemaDbContext dbContext)
        {
            //var worker = new Worker
            //{
            //    Id = Guid.NewGuid(),
            //    Name = request.Name,
            //    Number = request.Number,
            //    Salary = request.Salary,
            //    CinemaId = request.CinemaId,
            //    RoleId = request.RoleId
            //};
            await dbContext.Workers.AddAsync(request);
            await dbContext.SaveChangesAsync();
            return request.Id;
        }
    }
}

