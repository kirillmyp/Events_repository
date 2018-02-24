namespace Events_Repository.Models.Interface
{
    interface ICitySystem : IEntity
    {
        int Country { get; set; }
    }

    interface ICityView : IEntity
    {
        string Country { get; set; }
    }
}
