using System;
using System.Collections.Generic;
using ToDoList.Core.Utilities.Results;
using ToDoList.Entities.Concrete;

namespace ToDoList.Business.Abstract
{
    public interface IProjectService
    {
        IDataResult<List<Project>> GetAll();
        IResult Add(Project project);
        IResult Update(Project project);
        IResult Delete(Project project);
        IDataResult<Project> GetProject(Guid projectId);

    }
}
