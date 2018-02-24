namespace Events_Repository.Models
{
    using Interface;

    public class Role : IRole
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
