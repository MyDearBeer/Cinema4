using CinemaWebApi.DB;
using CinemaWebApi.Models;
using Microsoft.EntityFrameworkCore;

namespace CinemaWebApi.CQRS.Queries.RoleQuery
{
    public class GetRoleList
    {
        public static async Task<List<Role>> Get(ICinemaDbContext dbContext)
        {
            return await dbContext.Roles.ToListAsync();
        }
    }
}
