using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.Entities;
using ToDoList.Entities.Concrete;
using ToDoList.Entities.Shared;

namespace ToDoList.Entities.Dtos
{
    public class PartProjectDto :IDto
    {
         public Guid Id { get; set; }
         public string Title { get; set; }
         public Guid ProjectId { get; set; }
         public string ProjectName { get; set; }
         public ViewType ProjectViewType { get; set; }
       
     
    }
}
