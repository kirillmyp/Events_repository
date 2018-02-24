namespace Events_Repository.DALayout
{
    using System.Collections.Generic;
    using Models.Interface;

    public interface IOrganizationDataAccess
    {
        string GetAllOrganizationsJson();

        List<IOrganizationBaseView> GetAllOrganizations();

        IOrganizationFullView GetOrganizationById(int id);
    }
}
