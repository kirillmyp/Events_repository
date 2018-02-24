namespace Events_Repository.Models
{
    using Interface;

    public class Tag : ITag
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
