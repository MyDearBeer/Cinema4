namespace CinemaWebApi.Models
{
    public class Role
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<Worker> Workers { get; set; }
    }
}
