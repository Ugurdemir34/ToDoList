using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.DataAccess;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAccess.Abstract
{
    public interface IProjectDal : IEntityRepository<Project>
    {
    }
}
