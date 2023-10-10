using CinemaWebApi.DB;
using CinemaWebApi.Models;

namespace CinemaWebApi.CQRS.Commands.RoleCommand
{
    public class CreateRole
    {
        public static async Task<Guid> Create(Role request, ICinemaDbContext dbContext)
        {
           await dbContext.Roles.AddAsync(request);
            await dbContext.SaveChangesAsync();
            return request.Id;
        }
    }
}

