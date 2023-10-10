namespace CinemaWebApi.DB
{
    public class DbInitializer
    {
        public static void Initialize(CinemaDbContext context)
        {
            //context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
        }
    }
}
