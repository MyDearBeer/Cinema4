using CinemaWebApi.DB;
using CinemaWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApi.CQRS.Queries.RoleQuery
{
    public class GetRole
    {
        public static async Task<Role> Get(Guid id, ICinemaDbContext dbContext)
        {
            return await dbContext.Roles.FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
