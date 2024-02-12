using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
using DB.Models;
using ZstdSharp.Unsafe;

namespace DB
{
    public class DataProduct
    {
       static public List<Product> GetAll()
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                return context.Products.ToList();
            }
        }
        static public Product? GetOne(int id) 
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                return context.Products.FirstOrDefault(x => x.ProductId == id);
            }
        }

        static public void Insert(Product pro)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                var proAdd = GetOne(pro.ProductId);
                if (proAdd == null) {
                    context.Products.Attach(pro);
                    context.Entry(pro).State = EntityState.Added;
                    context.SaveChanges();
                }
            }
        }
        static public void DeleteOne(Product pro)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                var proDel = GetOne(pro.ProductId);
                if (proDel != null) {
                    context.Products.Attach(proDel);
                    context.Entry(proDel).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
        }

        static public void Update(Product pro, string product_name, decimal product_price)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                    var proMod = GetOne(pro.ProductId);  

                    proMod.ProductName = product_name;

                    proMod.ProductPrice = product_price;

                    context.Products.Attach(proMod);
                    context.Entry(proMod).State = EntityState.Modified;
                    context.SaveChanges();
                   

            }
         }

        static public void setStock(Product pro, int amount)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                var proMod = GetOne(pro.ProductId);

                proMod.setStock(amount);

                context.Products.Attach(proMod);
                context.Entry(proMod).State = EntityState.Modified;
                context.SaveChanges();


            }
        }
        

        
    }

}
