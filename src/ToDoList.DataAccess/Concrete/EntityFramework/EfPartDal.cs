using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToDoList.Core.DataAccess.EntityFramework;
using ToDoList.DataAccess.Abstract;
using ToDoList.Entities.Concrete;
using ToDoList.Entities.Dtos;

namespace ToDoList.DataAccess.Concrete.EntityFramework
{
    public class EfPartDal : EfEntityRepositoryBase<Part, ToDoListContext>, IPartDal
    {
        public List<PartProjectDto> GetAllParts()
        {
            using (var context = new ToDoListContext())
            {
                var part = context.Parts.Include(p => p.Project).Select(p =>
                 new PartProjectDto()
                 { 
                     Id=p.Id,
                     Title = p.Title,
                     ProjectId = p.Project.Id,
                     ProjectName = p.Project.Name,
                     ProjectViewType =p.Project.ViewType
                 });
                return part.ToList();
            }
        }
         
    }
}
