using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.Entities;

namespace ToDoList.Entities.Concrete
{
    public class Comment:IEntity
    {
        public Guid Id { get; set; }
        public string ContentText { get; set; }
        public DateTime CreationDate { get; set; }

        //Navigation Property
        public User User { get; set; }
    }
}