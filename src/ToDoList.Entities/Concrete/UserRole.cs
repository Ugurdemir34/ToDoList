using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Entities.Concrete
{
    public class UserRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        //Navigation Property
        public virtual User User { get; set; }
        public virtual Role Role { get; set; }
    }
}
