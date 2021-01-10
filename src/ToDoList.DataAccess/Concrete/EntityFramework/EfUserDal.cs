using ToDoList.Core.DataAccess.EntityFramework;
using ToDoList.DataAccess.Abstract;
using ToDoList.Entities.Concrete;
namespace ToDoList.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,ToDoListContext>,IUserDal
    {
        
    }
}