

namespace Events_Repository.Models
{
    using System;
    using Interface;

    public class OrganizationFullSystem : IOrganizationFullSystem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCommercial { get; set; }
        public bool IsChecked { get; set; }
        public DateTime Create { get; set; }
        public DateTime Modified { get; set; }
        public int CreateBy { get; set; }
        public int CityId { get; set; }
        public int CountryId { get; set; }
        public bool IsActive { get; set; }
        public string CheckedBy { get; set; }
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

    public class OrganizationFullView : IOrganizationFullView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCommercial { get; set; }
        public bool IsChecked { get; set; }
        public DateTime Create { get; set; }
        public DateTime Modified { get; set; }
        public string CreateBy { get; set; }
        public string CityId { get; set; }
        public string CountryId { get; set; }
        public bool IsActive { get; set; }
        public string CheckedBy { get; set; }
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
