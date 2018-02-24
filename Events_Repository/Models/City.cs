namespace Events_Repository.Models
{
    using Interface;

    public class City : ICitySystem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Country { get; set; }
    }

    public class CityView : ICityView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Country { get; set; }
    }
}
