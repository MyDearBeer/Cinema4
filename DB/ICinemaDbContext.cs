using CinemaWebApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CinemaWebApi.DB
{
    public interface ICinemaDbContext
    {
        DbSet<Cinema> Cinemas { get; set; }
        DbSet<Worker> Workers { get; set; }
        DbSet<Role> Roles { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
