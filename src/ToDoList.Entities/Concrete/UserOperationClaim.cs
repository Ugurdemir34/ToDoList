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
        public User User { get; set; }
        public OperationClaim OperationClaim { get; set; }
    }
}
