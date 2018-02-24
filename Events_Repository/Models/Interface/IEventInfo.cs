namespace Events_Repository.Models.Interface
{
    using System;

    interface IEventInfoSystem : IIdentity
    {
        DateTime Create { get; set; }
        DateTime Modifice { get; set; }
        int CreatedBy { get; set; }
        int ModificeBy { get; set; }
        int Admin { get; set; }
        int Moderator { get; set; }
        string Street { get; set; }
        string House { get; set; }
        string MapCoordinate { get; set; }
        bool IsSpecialProblem { get; set; }
        string Comment { get; set; }
        string Description { get; set; }
    }

    interface IEventInfoView : IIdentity
    {
        DateTime Create { get; set; }
        DateTime Modifice { get; set; }
        string CreatedBy { get; set; }
        string ModificeBy { get; set; }
        string Admin { get; set; }
        string Moderator { get; set; }
        string Street { get; set; }
        string House { get; set; }
        string MapCoordinate { get; set; }
        bool IsSpecialProblem { get; set; }
        string Comment { get; set; }
        string Description { get; set; }
    }
}
