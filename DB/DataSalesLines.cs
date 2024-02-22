using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;
using EF.Models;
using ZstdSharp.Unsafe;

namespace DB
{
    public class DataSalesLines
    {
       static public List<SalesLine> GetAll()
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                return context.SalesLines
                    .Include(x => x.Sale)
                    .Include(x => x.Product)
                    .ToList();
            }
        }
        static public SalesLine? GetOne(Sale sale_get, int sale_line_id) 
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                return context.SalesLines
                 .Include(x => x.Sale)
                 .Include(x => x.Product)
                 .FirstOrDefault(x => x.Sale.SaleId == sale_get.SaleId && x.LineId == sale_line_id);
            }
        }

        static public void Insert(SalesLine sales_line)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                var sales_lineAdd = GetOne(sales_line.Sale, sales_line.LineId);
                if (sales_lineAdd == null) {


                    handleAmounts(sales_line);
                  
                    context.Entry(sales_line).State = EntityState.Added;
                    
                    context.SaveChanges();
                }
            }
        }
        static public void DeleteOne(SalesLine sale_line)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                var sale_lineDel = GetOne(sale_line.Sale, sale_line.LineId);
                var product_saleline = DataProduct.GetOne(sale_lineDel.ProductId);
                var saleserched = DataSale.GetOne(sale_lineDel.SaleId);

                if (sale_lineDel != null) {

                    DataProduct.setStock(product_saleline, -(sale_lineDel.Amount));
                    DataSale.setTotal(saleserched, -(sale_lineDel.SubTotal));

                    context.SalesLines.Attach(sale_lineDel);
                    context.Entry(sale_lineDel).State = EntityState.Deleted;
                    context.SaveChanges();
                }
            }
        }

        static public void Update(Sale sale, SalesLine sale_line, Product pro, int amount)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                    var sale_line_mod = GetOne(sale_line.Sale, sale_line.LineId);

                    sale_line_mod.Sale = sale;
                    sale_line_mod.Product = pro;
                    sale_line_mod.SaleId = sale.SaleId;
                    sale_line_mod.setSubTotal(pro, amount);
                    sale_line_mod.Amount = amount;       
                
                    handleAmounts(sale_line_mod);

                    
                    context.Entry(sale_line_mod).State = EntityState.Modified;
                    context.SaveChanges();
                }
         }
        
        static private void handleAmounts(SalesLine sales_line) {

            if (sales_line.Product.getStock() >= sales_line.Amount)
            {
                DataProduct.setStock(sales_line.Product, sales_line.Amount);
            }
            else { throw new InvalidOperationException("Stock unenough"); }

            DataSale.setTotal(sales_line.Sale, sales_line.SubTotal);
        }

        static public List<SalesLine> saleslineSearcher(int sale_id)
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                return context.SalesLines
                    .Include(x => x.Sale)
                    .Include(x => x.Product)
                    .Where(x=>x.SaleId == sale_id).ToList();
            }
        }

    }

}
