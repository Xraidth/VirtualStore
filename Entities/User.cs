using System;
using System.Collections.Generic;

namespace EF.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string UserPassword { get; set; } = null!;
        public User() {}
        public User(string user_name, string user_password )
        {
            UserName = user_name;
            UserPassword = user_password;
        }

    }
    
}
