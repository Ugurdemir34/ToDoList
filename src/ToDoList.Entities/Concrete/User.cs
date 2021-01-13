using System;
using System.Collections.Generic;
using System.Text;
using ToDoList.Core.Entities;

namespace ToDoList.Entities.Concrete
{
    public class User:IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public DateTime CreationDate { get; set; }
        public bool EmailConfirmed { get; set; }
        public bool IsDeleted { get; set; }

        public List<UserOperationClaim> UserOperationClaims { get; set; }
        public List<UserRole> UserRoles { get; set; }
    }
}
