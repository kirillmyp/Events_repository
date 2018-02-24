namespace Events_Repository.Models.Interface
{
    using System;

    /// <summary>
    /// FullSystem's mean the subject contain information from both table DB and don't convert from Id to string(name something)
    /// </summary>
    interface IOrganizationFullSystem : IOrganizationBaseSystem, IOrganizationInfoSystem
    {
        //bool IsCommercial { get; set; }
        //bool IsChecked { get; set; }
        //DateTime Create { get; set; }
        //DateTime Modified { get; set; }
        //int CreateBy { get; set; }
        //int CityId { get; set; }
        //int CountryId { get; set; }
        //bool IsActive { get; set; }
        //string CheckedBy { get; set; }

        //string Inn { get; set; }
        //string Address { get; set; }
        //string Phone1 { get; set; }
        //string Phone2 { get; set; }
        //string Photo { get; set; }
        //string Street { get; set; }
        //int ContactFaceId { get; set; }
        //string ContactInfo { get; set; }
        ///// <summary>
        ///// the owner is a private face or a legal entity
        ///// </summary>
        //bool IsPrivate { get; set; }
    }

    /// <summary>
    /// FullView's mean the subject contain information from both table DB and convert from Id to string(name something) for client
    /// </summary>
    public interface IOrganizationFullView : IOrganizationBaseView, IOrganizationInfoView
    {
        //bool IsCommercial { get; set; }
        //bool IsChecked { get; set; }
        //DateTime Create { get; set; }
        //DateTime Modified { get; set; }
        //string CreateBy { get; set; }
        //string CityId { get; set; }
        //string CountryId { get; set; }
        //bool IsActive { get; set; }
        //string CheckedBy { get; set; }

        //string Inn { get; set; }
        //string Address { get; set; }
        //string Phone1 { get; set; }
        //string Phone2 { get; set; }
        //string Photo { get; set; }
        //string Street { get; set; }
        //string ContactFaceId { get; set; }
        //string ContactInfo { get; set; }
        ///// <summary>
        ///// the owner is a private face or a legal entity
        ///// </summary>
        //bool IsPrivate { get; set; }
    }
}
