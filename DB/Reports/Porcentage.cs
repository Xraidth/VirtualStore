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
            var sales_lines = DataSalesLines.GetAll();
            var sales = DataSale.GetAll();


            var sales_lines_today = new List<SalesLine>();
            var sales_today = sales.Where(x => x.SaleDay.Date == DateTime.Now.Date).ToList();

            if(sales_lines.Count != 0 && sales_today.Count!= 0){ 
            foreach (var sl in sales_lines)
            {
                foreach (var st in sales_today)
                {
                if(st.SaleId == sl.SaleId) { sales_lines_today.Add(sl); }
                }
            }
            }

            List<StockPorce> stock_porces = new List<StockPorce>();


            foreach (var p in products)
            {
                int amount_saled = sales_lines_today
                    .Where(x => x.ProductId == p.ProductId)
                    .ToList()
                    .Sum(s => s.Amount);


                decimal porce_stock = 0;

                if (p.ProductStock != 0) { 
                int total_stock = (amount_saled) + p.ProductStock;

                var porce = ((p.ProductStock) * 100 / total_stock);
                porce_stock = Math.Truncate(Convert.ToDecimal(porce) * 1000) / 1000;
                }
                else
                {
                    porce_stock = 0;
                }

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
