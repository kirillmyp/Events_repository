﻿namespace Events_Repository.Models
{
    using Interface;

    public class Entity: IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
