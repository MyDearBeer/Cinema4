using CinemaWebApi.DB;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddPersistence(builder.Configuration);
using (var scope = builder.Services.BuildServiceProvider().CreateScope())
{
    var serviceProvider = scope.ServiceProvider;
    try
    {
        var context = serviceProvider.GetRequiredService<CinemaDbContext>();
        DbInitializer.Initialize(context);
    }
    catch (Exception exeption)
    {

    }
}
builder.Services.AddControllers();

var app = builder.Build();
app.MapControllers();

app.Run();
