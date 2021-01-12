using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.DataAccess.EntityFramework;
using ToDoList.DataAccess.Abstract;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAccess.Concrete.EntityFramework
{
    public class EfOperationClaimDal : EfEntityRepositoryBase<OperationClaim, ToDoListContext>, IOperationClaimDal
    {
    }
}
