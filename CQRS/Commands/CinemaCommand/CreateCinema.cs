using CinemaWebApi.DB;
using CinemaWebApi.Models;

namespace CinemaWebApi.CQRS.Commands.CinemaCommand
{
    public class CreateCinema
    {
        public static async Task<Guid> Create(Cinema request, ICinemaDbContext dbContext)
        {
         
            await dbContext.Cinemas.AddAsync(request);
            await dbContext.SaveChangesAsync();
            return request.Id;
        }
    }
}
