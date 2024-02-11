using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
using DB.Models;
using ZstdSharp.Unsafe;

namespace DB
{
    public class DataSale
    {
       static public List<Sale> GetAll()
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                return context.Sales.ToList();
            }
        }
        static public Sale? GetOne(int id) 
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                return context.Sales.FirstOrDefault(x => x.SaleId == id);
            }
        }

        static public void Insert(Sale sale)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                var saleAdd = GetOne(sale.SaleId);
                if (saleAdd == null) { 
                context.Sales.Add(sale);
                context.SaveChanges();
                }
            }
        }
        static public void DeleteOne(Sale sale)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                var saleDel = GetOne(sale.SaleId);
                if (saleDel != null) { 
                context.Sales.Remove(saleDel);
                context.SaveChanges();
                }
            }
        }

        static public void Update(Sale sale, User usu, decimal total, DateTime sale_day)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                    var saleMod = GetOne(sale.SaleId);  
                    saleMod.Total = total;
                    saleMod.SaleDay = sale_day;
                    saleMod.UserName = usu.UserName;

                    context.Sales.Attach(saleMod);
                    context.Entry(saleMod).State = EntityState.Modified;
                    context.SaveChanges();
                   

                }
         }
        

       
    }

}
