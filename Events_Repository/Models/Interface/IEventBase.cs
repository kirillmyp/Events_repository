using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events_Repository.Models.Interface
{
    interface IEventBaseSystem : IEntity
    {
        int TypeId { get; set; }
        DateTime DateStart { get; set; }
        DateTime DateFinish { get; set; }
        string Photo { get; set; }
        int CountryId { get; set; }
        int CityId { get; set; }
        bool IsChecked { get; set; }
        bool IsActive { get; set; }
        string Price { get; set; }
        string ReducedDescription { get; set; }
        bool IsFree { get; set; }
    }

    interface IEventBaseView : IEntity
    {
        string TypeId { get; set; }
        DateTime DateStart { get; set; }
        DateTime DateFinish { get; set; }
        string Photo { get; set; }
        string Country { get; set; }
        string City { get; set; }
        bool IsChecked { get; set; }
        bool IsActive { get; set; }
        string Price { get; set; }
        string ReducedDescription { get; set; }
        bool IsFree { get; set; }
    }
}
