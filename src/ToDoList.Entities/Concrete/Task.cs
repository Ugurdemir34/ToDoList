using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.Entities;
using ToDoList.Entities.Shared;

namespace ToDoList.Entities.Concrete
{
    public class Task:IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }       
        public DateTime DeadLine { get; set; }
        public PriorityType Priority { get; set; }
        public bool Status { get; set; }
        
        //Navigation Property
        public Project Project { get; set; }
        public Comment Comment { get; set; }
        public Task ParenTask { get; set; }
        public User User { get; set; }
        public Part Part { get; set; }
       
    }
}
