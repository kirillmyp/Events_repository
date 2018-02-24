namespace Events_Repository.Models
{
    using System;
    using Interface;

    public class EventInfoSystem : IEventInfoSystem
    {
        public int Id { get; set; }
        public DateTime Create { get; set; }
        public DateTime Modifice { get; set; }
        public int CreatedBy { get; set; }
        public int ModificeBy { get; set; }
        public int Admin { get; set; }
        public int Moderator { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string MapCoordinate { get; set; }
        public bool IsSpecialProblem { get; set; }
        public string Comment { get; set; }
        public string Description { get; set; }
    }

    public class EventInfoView : IEventInfoView
    {
        public int Id { get; set; }
        public DateTime Create { get; set; }
        public DateTime Modifice { get; set; }
        public string CreatedBy { get; set; }
        public string ModificeBy { get; set; }
        public string Admin { get; set; }
        public string Moderator { get; set; }
        public string Street { get; set; }
        public string House { get; set; }
        public string MapCoordinate { get; set; }
        public bool IsSpecialProblem { get; set; }
        public string Comment { get; set; }
        public string Description { get; set; }
    }

}
