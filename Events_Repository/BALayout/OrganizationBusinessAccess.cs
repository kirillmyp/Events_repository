namespace Events_Repository.BALayout
{
    using DALayout;
    using System.Collections.Generic;
    using Models.Interface;

    public class OrganizationBusinessAccess : IOrganizationBusinessAccess
    {
        private IOrganizationDataAccess _organizationDA;

        public OrganizationBusinessAccess(IOrganizationDataAccess organizationDA)
        {
            _organizationDA = organizationDA;
        }
        public string GetAllOrganizationsJson()
        {
            return _organizationDA.GetAllOrganizationsJson();
        }

        public List<IOrganizationBaseView> GetAllOrganizations()
        {
            return _organizationDA.GetAllOrganizations();
        }

        public IOrganizationFullView GetOrganizationById(int? id)
        {
            if (!id.HasValue)
            {
                return null;
            }
            return _organizationDA.GetOrganizationById(id.Value);
        }
    }
}
