using System;
using Microsoft.AspNetCore.Mvc;

namespace application.Models
{
    public class User
    {
        internal ActionResult<User> password;

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        internal ActionResult<User> json(object password)
        {
            throw new NotImplementedException();
        }
    }
}