using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandle.Reports
{
    public class ProductPorce
    {
        public int ProductPorceId { get; set; }
        public string ProductName { get; set; }
        public string Porcentage { get; set; }

       public ProductPorce( int id, string name, string porce)
        {
            ProductPorceId = id;
            ProductName = name;
            Porcentage = porce;
        }
    }

}
