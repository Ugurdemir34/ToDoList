using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Business.Abstract;
using ToDoList.Business.Constants;
using ToDoList.Core.Utilities.Results;
using ToDoList.DataAccess.Abstract;
using ToDoList.Entities.Concrete;
using ToDoList.Entities.Dtos;

namespace ToDoList.Business.Concrete
{
    public class PartManager : IPartService
    {
        private IPartDal _partDal;
        public PartManager(IPartDal partDal)
        {
            _partDal = partDal;
        }
        public IResult Add(Part part)
        {
            if (part == null)
            {
                return new ErrorResult(Messages.PartAddingError);
            }
            return new SuccessResult(Messages.PartAdded);
        }

        public IResult Delete(Part part)
        {
            if (part == null)
            {
                return new ErrorResult(Messages.PartDeletingError);
            }
            return new SuccessResult(Messages.PartDeleted);
        }

        public IDataResult<List<PartProjectDto>> GetAll()
        {
            try
            {
                var model = _partDal.GetAllParts();              
                return new SuccessDataResult<List<PartProjectDto>>(model, Messages.PartList);
            }
            catch (Exception ex)
            {

                return new ErrorDataResult<List<PartProjectDto>>(ex.Message);
            }
        }

        public IDataResult<Part> GetPart(Guid partId)
        {
            try
            {
                var model = _partDal.Get(i => i.Id == partId);             
                return new SuccessDataResult<Part>(Messages.PartGet);
            }
            catch (Exception ex)
            {               
                return new ErrorDataResult<Part>(ex.Message);
            }
        }
        public IDataResult<Part> GetPartByProjectId(Guid projectId)
        {
            try
            {
                var model = _partDal.Get(i=>i.Project.Id == projectId);
                if (model != null)
                    return new SuccessDataResult<Part>(model, Messages.PartGet);
                else
                    return new ErrorDataResult<Part>(Messages.PartGetByProject);
            }
            catch (Exception ex)
            {
                return new ErrorDataResult<Part>(ex.Message);
            }
        }
        public IResult Update(Part part)
        {
            if (part == null)
            {
                return new ErrorResult(Messages.PartUpdatingError);
            }
            return new SuccessResult(Messages.PartUpdated);
        }
    }
}
