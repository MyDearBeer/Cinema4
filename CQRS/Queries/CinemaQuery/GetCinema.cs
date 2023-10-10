using CinemaWebApi.DB;
using CinemaWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApi.CQRS.Queries.CinemaQuery
{
    public class GetCinema
    {
        public static async Task<Cinema> Get(Guid id,ICinemaDbContext dbContext)
        {
            return await dbContext.Cinemas.FirstOrDefaultAsync(c=> c.Id == id);
        }
    }
}
