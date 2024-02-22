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
        public static List<StockPorce> CalculatePorceStock()
        {
            var products = DataProduct.GetAll();

            
            List<StockPorce> stock_porces = new List<StockPorce>();

            int total_stock = products.Sum(p => p.ProductStock);

            foreach (var p in products)
            {
                
                var porce = ((p.ProductStock) * 100 / total_stock);
                var porce_stock = Math.Truncate(Convert.ToDecimal(porce) * 1000) / 1000;
                var sp = new StockPorce(p.ProductName, $"{porce_stock}%");
                stock_porces.Add(sp);    
            }

            
            stock_porces = stock_porces.OrderByDescending(sp => Decimal.Parse(sp.Porcentage.Replace("%", ""))).ToList();



            int productId = 1;
            foreach (var item in stock_porces)
            {
                item.ProductPorceId = productId;
                productId++;
            }



            return stock_porces;
        }

        public static List<ProductSalePorce> CalculatePorceProductSales()
        {
            List<ProductSalePorce> sales_porces = new List<ProductSalePorce>();

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
                    var sp = new ProductSalePorce(p.ProductName, $"{porce_stock}%");
                    sales_porces.Add(sp);
                }
            }



            sales_porces = sales_porces.OrderByDescending(sp => Decimal.Parse(sp.Porcentage.Replace("%", ""))).ToList();



            int productId = 1;
            foreach (var item in sales_porces)
            {
                item.ProductPorceId = productId;
                productId++;
            }

            return sales_porces;
        }

        

    }
}
