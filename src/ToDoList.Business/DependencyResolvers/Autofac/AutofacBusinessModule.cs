using Autofac;
using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Business.Abstract;
using ToDoList.Business.Concrete;
using ToDoList.DataAccess.Abstract;
using ToDoList.DataAccess.Concrete.EntityFramework;

namespace ToDoList.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProjectManager>().As<IProjectService>();
            builder.RegisterType<EfProjectDal>().As<IProjectDal>();
        }
    }
}
