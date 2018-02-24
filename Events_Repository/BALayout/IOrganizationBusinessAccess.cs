namespace Events_Repository.BALayout
{
    using System.Collections.Generic;
    using Models.Interface;

    public interface IOrganizationBusinessAccess
    {
        string GetAllOrganizationsJson();

        /// <summary>
        /// For clien side
        /// </summary>
        /// <returns></returns>
        List<IOrganizationBaseView> GetAllOrganizations();

        /// <summary>
        /// For clien side
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IOrganizationFullView GetOrganizationById(int? id);

    }
}
