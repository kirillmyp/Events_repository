namespace Events_Repository.Models
{
    using Interface;

    public class OrganizationInfoSystem : IOrganizationInfoSystem
    {
        public int Id { get; set; }
        //public int OrganizationId { get; set; }
        public string Inn { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Photo { get; set; }
        public string Street { get; set; }
        public int ContactFaceId { get; set; }
        public string ContactInfo { get; set; }
        public bool IsPrivate { get; set; }
    }

    public class OrganizationInfoView : IOrganizationInfoView
    {
        public int Id { get; set; }
        //public int OrganizationId { get; set; }
        public string Inn { get; set; }
        public string Address { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Photo { get; set; }
        public string Street { get; set; }
        public string ContactFaceId { get; set; }
        public string ContactInfo { get; set; }
        public bool IsPrivate { get; set; }
    }
}
