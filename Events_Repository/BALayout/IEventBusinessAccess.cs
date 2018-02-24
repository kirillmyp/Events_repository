namespace Events_Repository.BALayout
{
    using System.Collections.Generic;
    using Models.Interface;

    interface IEventBusinessAccess
    {
        List<IEventHistory> GetHistoriesById(int? id);
        List<IEventTag> GetTagsById(int? id);
        List<IEventOrganizer> GetOrganizerById(int? id);
    }
}
