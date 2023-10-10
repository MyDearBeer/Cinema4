namespace CinemaWebApi.Models
{
    public class Cinema
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public List<Worker> Workers { get; set; }
    }
}
