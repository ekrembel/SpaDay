using System;
using System.Collections.Generic;

namespace SpaDay.Models
{
    public class User
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Date { get; set; }

        public List<User> Users = new List<User>();

        public User()
        {
            Date = DateTime.Now;
        }


    }
}
