namespace Events_Repository.Models
{
    using Interface;

    public class ParticipantEvent : IUser
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
    }
}
