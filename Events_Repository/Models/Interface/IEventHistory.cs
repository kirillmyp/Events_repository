namespace Events_Repository.Models.Interface
{
    interface IEventHistory : IIdentity
    {
        int EventId { get; set; }
        string AdditionalInfo { get; set; }
        int ChangeId { get; set; }//todo create an enum
    }
}
