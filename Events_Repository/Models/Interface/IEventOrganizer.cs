using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events_Repository.Models.Interface
{
    interface IEventOrganizer : IIdentity
    {
        int EventId { get; set; }
        string Photo { get; set; }
        int UserId { get; set; }
        string Description { get; set; }
    }
}
