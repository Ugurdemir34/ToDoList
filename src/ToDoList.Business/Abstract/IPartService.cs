using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.Utilities.Results;
using ToDoList.Entities.Concrete;
using ToDoList.Entities.Dtos;

namespace ToDoList.Business.Abstract
{
    public interface IPartService
    {
       // IDataResult<List<Part>> GetAll();
        IResult Add(Part part);
        IResult Update(Part part);
        IResult Delete(Part part);
        IDataResult<Part> GetPart(Guid partId);
        IDataResult<Part> GetPartByProjectId(Guid projectId);
        IDataResult<List<PartProjectDto>> GetAll();
    }
}
