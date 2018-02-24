namespace Events_Repository.Models
{
    using Interface;

    public class Ticket : ITicket
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int EventId { get; set; }
        public int TotalyCount { get; set; }
        public int Residue { get; set; }
        public int ResidueWithDiscount { get; set; }
        public string Promocode { get; set; }
        public string Price { get; set; }
    }
}
