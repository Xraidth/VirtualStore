using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
using DB.Models;
using ZstdSharp.Unsafe;

namespace DB
{
    public class DataUser
    {
       static public List<User> GetAll()
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                return context.Users.ToList();
            }
        }
        static public User? GetOne(int id) 
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                return context.Users.FirstOrDefault(x => x.UserId == id);
            }
        }

        static public void Insert(User usu)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                var usuAdd = GetOne(usu.UserId);
                if (usuAdd == null) {
                    context.Users.Attach(usu);
                    context.Entry(usu).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
        }
        static public void DeleteOne(User usu)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                var usuDel = GetOne(usu.UserId);
                if (usuDel != null) {
                    context.Users.Attach(usuDel);
                    context.Entry(usuDel).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
        }

        static public void Update(User usu, string user_name, string user_password)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                    var usuMod = GetOne(usu.UserId);  
                    usuMod.UserName = user_name;
                    usuMod.UserPassword = user_password;

                    context.Users.Attach(usuMod);
                    context.Entry(usuMod).State = EntityState.Modified;
                    context.SaveChanges();
                   

                }
         }

        static public User? SignIn(string user_name, string user_password)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                return context.Users.FirstOrDefault(x => x.UserName == user_name && x.UserPassword == user_password);
            }
        }
        

       
    }

}
