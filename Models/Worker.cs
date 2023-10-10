namespace CinemaWebApi.Models
{
    public class Worker
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Number { get; set; }
        public int Salary { get; set; }
        public Guid CinemaId { get; set; }
        public Guid RoleId { get; set; }
        public Cinema Cinema { get; set; }
        public Role Role { get; set; }
    }
}
