namespace Events_Repository.Models.Interface
{
    public interface IUser : IIdentity
    {
        //string FirstName { get; set; }
        //string MiddleName { get; set; }
        //string LastName { get; set; }
        string Email { get; set; }
        string Login { get; set; }
    }
}
