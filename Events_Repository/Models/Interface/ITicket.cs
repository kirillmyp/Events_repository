namespace Events_Repository.Models.Interface
{
    interface ITicket : IEntity
    {
        int EventId { get; set; }
        int TotalyCount { get; set; }
        int Residue { get; set; }
        int ResidueWithDiscount { get; set; }
        string Promocode { get; set; }
        string Price { get; set; }
    }
}
