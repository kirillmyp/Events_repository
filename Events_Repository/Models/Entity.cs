using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Events_Repository.Models.Interface;

namespace Events_Repository.Models
{
    public class Entity: IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
