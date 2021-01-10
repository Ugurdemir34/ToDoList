using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.Entities;

namespace ToDoList.Entities.Concrete
{
    public class OperationClaim:IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<UserOperationClaim> userOperationClaims { get; set; }
    }
}
