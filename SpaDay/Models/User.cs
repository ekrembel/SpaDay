using System;
using System.Collections.Generic;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Id { get; }
        private static int nextId = 1;

        

        public User()
        {
            Id = nextId;
            nextId++;
        }

        public User(string u, string e, string p) : this()
        {
            Username = u;
            Email = e;
            Password = p;
        }

    }
}
