using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.Entities;
using ToDoList.Entities.Shared;

namespace ToDoList.Entities.Concrete
{
    public class Project:IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ViewType ViewType { get; set; }

        //Navigation Property
        public User User { get; set; }
        public List<Part> Parts { get; set; }
    }
}