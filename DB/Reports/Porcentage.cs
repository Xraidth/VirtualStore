using DataHandle.Reports;
using EF.Models;
using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB.Reports
{
    public class Porcentage
    {
        public static List<ProductPorce> CalculatePorceStock()
        {
            var products = DataProduct.GetAll();

            
            List<ProductPorce> stock_porces = new List<ProductPorce>();

            int total_stock = products.Sum(p => p.ProductStock);

            foreach (var (p, indice) in products.Select((value, index) => (value, index)))
            {
                
                var porce = ((p.ProductStock) * 100 / total_stock);
                var porce_stock = Math.Truncate(Convert.ToDecimal(porce) * 1000) / 1000;
                var sp = new ProductPorce(indice, p.ProductName, $"{porce_stock}%");
                stock_porces.Add(sp);    
            }

            return stock_porces;
        }

        public static List<ProductPorce> CalculatePorceProductSales(string typePeriod)
        {
            List<ProductPorce> sales_porces = new List<ProductPorce>();

            var products = DataProduct.GetAll();
            var sales_lines = DataSalesLines.GetAll();

            decimal total_amount = sales_lines.Sum(s => s.Amount);

            if (total_amount != 0)
            {
                foreach (var (p, indice) in products.Select((value, index) => (value, index)))
                {
                    decimal porce = sales_lines
                                  .Where(sl => sl.ProductId == p.ProductId)
                                  .Sum(sl => sl.Amount) * 100 / total_amount;

                    var porce_stock = Math.Truncate(Convert.ToDecimal(porce) * 1000) / 1000;
                    var sp = new ProductPorce(indice, p.ProductName, $"{porce_stock}%");
                    sales_porces.Add(sp);
                }
            }
            
                

            return sales_porces;
        }

        

    }
}
