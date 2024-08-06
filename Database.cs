using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PART2_TASK1_
{
    public static class Database
    {
        // our db list of allowed users
        public static List<User> Users { get; set; } = new List<User>()
        {
            new User {Name="JAMES",Password="1234", Email= "james@school.edu"},

            new User {Name="ALICE",Password="4321", Email= "alice@school.edu"}
        };

        public static bool ValidateUser(string? username, string? password)
        {
            User user = new User()
            {
                Name= username,
                Password= password
            };

            // this will loop through each user and check if the one entered exists
            foreach (User A in Users)
            {
                if (A.Name == username && A.Password == password)
                {
                    return true;
                }
            }
            // returns false if user doesn't exist
            return false;
        }

        public static bool AddUser(string? username, string? password, string? email)
        {
            foreach (User A in Users)
            {
                // check if username exists
                if (A.Name.Contains(username))
                {
                    return false;
                }
            }
            // add the user to our db list
            User user = new User() { Name = username, Password = password, Email = email };
            Users.Add(user);
            return true;

        }
    }
}
