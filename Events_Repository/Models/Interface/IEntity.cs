namespace Events_Repository.Models.Interface
{
    public interface IEntity : IIdentity
    {
        string Title { get; set; }
    }   
}
