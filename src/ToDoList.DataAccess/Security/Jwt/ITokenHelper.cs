using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAccess.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaim);
    }
}
