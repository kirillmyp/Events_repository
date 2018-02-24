namespace Events_Repository.Models.Interface
{
    interface IEventFullSystem : IEventBaseSystem, IEventInfoSystem
    {
        //int TypeId { get; set; }
        //DateTime DateStart { get; set; }
        //DateTime DateFinish { get; set; }
        //string Photo { get; set; }
        //int CountryId { get; set; }
        //int CityId { get; set; }
        //bool IsChecked { get; set; }
        //bool IsActive { get; set; }
        //string Price { get; set; }
        //string ReducedDescription { get; set; }
        //bool IsFree { get; set; }

        //DateTime Create { get; set; }
        //DateTime Modifice { get; set; }
        //int CreatedBy { get; set; }
        //int ModificeBy { get; set; }
        //int Admin { get; set; }
        //int Moderator { get; set; }
        //string Street { get; set; }
        //string House { get; set; }
        //string MapCoordinate { get; set; }
        //bool IsSpecialProblem { get; set; }
        //string Comment { get; set; }
        //string Description { get; set; }

        //ParticipantEvent[] Participants { get; set; }
    }

    interface IEventFullView : IEventBaseView, IEventInfoView
    {
        //string TypeId { get; set; }
        //DateTime DateStart { get; set; }
        //DateTime DateFinish { get; set; }
        //string Photo { get; set; }
        //string Country { get; set; }
        //string City { get; set; }
        //bool IsChecked { get; set; }
        //bool IsActive { get; set; }
        //string Price { get; set; }
        //string ReducedDescription { get; set; }
        //bool IsFree { get; set; }

        //DateTime Create { get; set; }
        //DateTime Modifice { get; set; }
        //string CreatedBy { get; set; }
        //string ModificeBy { get; set; }
        //string Admin { get; set; }
        //string Moderator { get; set; }
        //string Street { get; set; }
        //string House { get; set; }
        //string MapCoordinate { get; set; }
        //bool IsSpecialProblem { get; set; }
        //string Comment { get; set; }
        //string Description { get; set; }

        //ParticipantEvent[] Participants { get; set; }
    }
}
