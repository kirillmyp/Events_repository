namespace Events_Repository.Models
{
    using Interface;

    public class Country : ICountry
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
