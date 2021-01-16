using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Business.Abstract;
using ToDoList.Business.Constants;
using ToDoList.Core.Utilities.Results;
using ToDoList.DataAccess.Abstract;
using ToDoList.Entities.Concrete;

namespace ToDoList.Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        private IProjectDal _projectDal;
        public ProjectManager(IProjectDal projectDal)
        {
            _projectDal = projectDal;
        }
        public IResult Add(Project project)
        {
            if(project==null)
            {
                return new ErrorResult(Messages.ProjectAddingError);
            }
            return new SuccessResult(Messages.ProjectAdded);
        }

        public IResult Delete(Project project)
        {
            if (project == null)
            {
                return new ErrorResult(Messages.ProjectDeletingError);
            }
            return new SuccessResult(Messages.ProjectDeleted);
        }

        public IDataResult<List<Project>> GetAll()
        {
            var model = _projectDal.GetList();
            return new SuccessDataResult<List<Project>>(model, Messages.ProjectList);
        }

        public IDataResult<Project> GetProject(Guid projectId)
        {
            var model = _projectDal.Get(i=>i.Id==projectId);
            if(model == null)
            {
                return new ErrorDataResult<Project>(Messages.ProjectGetError);
            }
            return new SuccessDataResult<Project>(model, Messages.ProjectGet);
        }

        public IResult Update(Project project)
        {
            return new SuccessResult(Messages.ProjectUpdated);
        }
    }
}
