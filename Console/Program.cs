using DB;
using DB.Models;
using Mysqlx.Crud;
using System;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {


            var newSL = new SalesLine(DataSale.GetOne(2), DataProduct.GetOne(1), 1);

            DataSalesLines.Insert(newSL);
          
          
            foreach (var s in DataSalesLines.GetAll() )
            {
                Console.WriteLine(s.LineId.ToString()+"\t"+ s.SaleId.ToString()+"\t"+s.ProductId.ToString()+"\t"+ s.SubTotal.ToString()+"\t"+ s.Amount.ToString());
            }
          

           









            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
