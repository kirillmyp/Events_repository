namespace Events_Repository.Models
{
    using System;
    using Interface;
    public class EventViewModel:IEvent
    {
        public int Id { get; set; }
        public int TypeEvent { get; set; }
        public int CreatedBy { get; set; }
        public int ModificeBy { get; set; }
        public DateTime DateStart { get; set; }
        public DateTime DateFinish { get; set; }
        public bool IsFree { get; set; }
        public string Price { get; set; }
        public string Title { get; set; }
        public bool IsChecked { get; set; }
        public string Inn { get; set; }
        public string Image { get; set; }
    }
}
