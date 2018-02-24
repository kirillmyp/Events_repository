namespace Events_Repository.Models
{
    using System;
    using Interface;

    public class EventFullSystem : IEventFullSystem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int TypeId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public string Photo { get; set; }
        public int CountryId { get; set; }
        public int CityId { get; set; }
        public bool IsChecked { get; set; }
        public bool IsActive { get; set; }
        public string Price { get; set; }
        public string ReducedDescription { get; set; }
        public bool IsFree { get; set; }
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

    public class EventFullView : IEventFullView
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string TypeId { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public string Photo { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public bool IsChecked { get; set; }
        public bool IsActive { get; set; }
        public string Price { get; set; }
        public string ReducedDescription { get; set; }
        public bool IsFree { get; set; }
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
