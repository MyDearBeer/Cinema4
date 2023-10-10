using CinemaWebApi.DB;
using CinemaWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApi.CQRS.Queries.CinemaQuery
{
    public class GetCinemaList
    {
        public static async Task<List<Cinema>> Get(ICinemaDbContext dbContext)
        {
            return await dbContext.Cinemas.ToListAsync();
        }
    }
}
