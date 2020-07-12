using System;
using System.Collections.Generic;
using SpaDay.Models;

namespace SpaDay.Data
{
    public class UserData
    {
        static private Dictionary<int, User> Users { get; set; } = new Dictionary<int, User>();

        public static void AddUser(User newUser)
        {
            Users.Add(newUser.Id, newUser);
        }
    }
}
