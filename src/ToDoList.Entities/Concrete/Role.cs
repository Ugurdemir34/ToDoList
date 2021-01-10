using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.Entities;

namespace ToDoList.Entities.Concrete
{
    public class Role:IEntity
    {
        public Guid Id { get; set; }
        public string RoleName { get; set; }
        public DateTime CreationDate { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
