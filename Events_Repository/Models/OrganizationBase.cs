namespace Events_Repository.Models
{
    using System;
    using Interface;

    public class OrganizationBaseSystem : IOrganizationBaseSystem
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
    }

    public class OrganizationBaseView : IOrganizationBaseView
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
    }
}
