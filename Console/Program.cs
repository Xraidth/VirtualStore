using DB;
using DB.Models;
using System;

namespace MiProyecto
{
    class Program
    {
        static void Main(string[] args)
        {

            

            foreach (var pro in DataProduct.GetAll() )
            {
                Console.WriteLine(pro.ProductId.ToString() + "\t" + pro.ProductName + "\t" + pro.ProductPrice.ToString());
            }

           

            

         
            
            
          


            Console.WriteLine("Presiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
