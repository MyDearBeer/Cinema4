using CinemaWebApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CinemaWebApi.DB.EntityConfiguration
{
    public class WorkerConfiguration : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.HasKey(w => w.Id);
            builder.HasIndex(w => w.Id).IsUnique();
            builder.HasIndex(w => w.Number).IsUnique();
            builder.HasOne(w=> w.Cinema).
                WithMany(c=> c.Workers).
                HasForeignKey(w=> w.CinemaId);
            builder.HasOne(w => w.Role).
                WithMany(r => r.Workers).
                HasForeignKey(w => w.RoleId);
        }
    }
}
