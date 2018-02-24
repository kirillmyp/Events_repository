using System;

namespace Events_Repository.Models
{
    using Interface;

    public class EventBaseSystem : IEventBaseSystem
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
    }

    public class EventBaseView : IEventBaseView
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
    }
}
