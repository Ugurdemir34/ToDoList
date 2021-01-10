using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.Entities.Concrete
{
    public class UserOperationClaim
    {
        public Guid UserId { get; set; }
        public Guid OperationClaimId { get; set; }
        
        //Navigation Property
        public virtual User User { get; set; }
        public virtual OperationClaim OperationClaim { get; set; }
    }
}
