namespace Events_Repository.Models.Interface
{
    using System;

    interface IOrganizationBaseSystem : IEntity
    {
        bool IsCommercial { get; set; }
        bool IsChecked { get; set; }
        DateTime Create { get; set; }
        DateTime Modified { get; set; }
        int CreateBy { get; set; }
        int CityId { get; set; }
        int CountryId { get; set; }
        bool IsActive { get; set; }
        string CheckedBy { get; set; }
    }

    public interface IOrganizationBaseView : IEntity
    {
        bool IsCommercial { get; set; }
        bool IsChecked { get; set; }
        DateTime Create { get; set; }
        DateTime Modified { get; set; }
        string CreateBy { get; set; }
        string CityId { get; set; }
        string CountryId { get; set; }
        bool IsActive { get; set; }
        string CheckedBy { get; set; }
    }
}