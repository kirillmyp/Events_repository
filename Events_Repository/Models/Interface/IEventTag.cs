using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events_Repository.Models.Interface
{
    interface IEventTag : IIdentity
    {
        int EventId { get; set; }
        int TagId { get; set; }
    }
}
