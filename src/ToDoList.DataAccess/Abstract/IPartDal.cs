using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.DataAccess;
using ToDoList.Entities.Concrete;
using ToDoList.Entities.Dtos;

namespace ToDoList.DataAccess.Abstract
{
    public interface IPartDal : IEntityRepository<Part>
    {
        List<PartProjectDto> GetAllParts();
    }
}
