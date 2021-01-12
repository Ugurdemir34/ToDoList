using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.Entities;

namespace ToDoList.Entities.Concrete
{
    public class Part :IEntity
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        //Navigation Property
        public List<Task> Tasks { get; set; }
        public Project Project { get; set; }
    }
}
