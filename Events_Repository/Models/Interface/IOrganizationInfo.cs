namespace Events_Repository.Models.Interface
{
    interface IOrganizationInfoSystem : IIdentity
    {
        //int OrganizationId { get; set; }
        string Inn { get; set; }
        string Address { get; set; }
        string Phone1 { get; set; }
        string Phone2 { get; set; }
        string Photo { get; set; }
        string Street { get; set; }
        int ContactFaceId { get; set; }
        string ContactInfo { get; set; }
        /// <summary>
        /// the owner is a private face or a legal entity
        /// </summary>
        bool IsPrivate { get; set; }
    }

    public interface IOrganizationInfoView : IIdentity
    {
        //int OrganizationId { get; set; }
        string Inn { get; set; }
        string Address { get; set; }
        string Phone1 { get; set; }
        string Phone2 { get; set; }
        string Photo { get; set; }
        string Street { get; set; }
        string ContactFaceId { get; set; }
        string ContactInfo { get; set; }
        /// <summary>
        /// the owner is a private face or a legal entity
        /// </summary>
        bool IsPrivate { get; set; }
    }
}