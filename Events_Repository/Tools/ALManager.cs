namespace Events_Repository.Tools
{
    using DALayout;
    using BALayout;

    /// <summary>
    /// Factory 
    /// </summary>
    public class ALManager
    {
        public IOrganizationBusinessAccess GetOrganizationBA()
        {
            return new OrganizationBusinessAccess(new OrganizationDataAccess());
        }

        public IUserBusinessAccess GetLoginBA()
        {
            return new UserBusinessAccess(new UserDataAccess());
        }
    }
}
