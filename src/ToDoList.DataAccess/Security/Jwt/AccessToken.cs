using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoList.DataAccess.Security.Jwt
{
    public class AccessToken
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
