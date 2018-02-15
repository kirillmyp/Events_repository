namespace Events_Repository.Models.Interface
{
    interface IUser : IEntity
    {
        //string FirstName { get; set; }
        //string MiddleName { get; set; }
        //string LastName { get; set; }
        string Email { get; set; }
        string Login { get; set; }
        int RoleId { get; set; }
    }
}
