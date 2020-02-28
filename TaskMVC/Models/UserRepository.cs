using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TaskMVC.Models
{
    public class UserRepository
    {
        private static List<User> users = new List<User>
        {
            new User {Id=1,Name="Name1" },
             new User {Id=2,Name="Name2" },
              new User {Id=3,Name="Name3" },
               new User {Id=4,Name="Name4" }
        };
        private int GetId()
        {
            return users.Any() ? users.Last().Id + 1 : 1;
        }

        public List<User> GetAllUsers()
        {
            return users;
        }

        public User GetUserById(int id)
        {
            return users.FirstOrDefault(x => x.Id == id);
        }

        public User Create(User user)
        {
            user.Id = GetId();
            users.Add(user);
            return user;
        }

        public User Update(User newUser)
        {
            var user = users.FirstOrDefault(x => x.Id == newUser.Id);
            user.Name = newUser.Name;
            return user;
        }

        public User Delete(int id)
        {
            var user = users.FirstOrDefault(x => x.Id == id);
            users.Remove(user);
            return user;
        }
    }
}