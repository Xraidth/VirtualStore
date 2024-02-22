using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataHandle.Reports
{
    public class ProductSalePorce
    {
        public int ProductPorceId { get; set; }
        public string ProductName { get; set; }
        public string Porcentage { get; set; }

        public ProductSalePorce(string name, string porce)
        {
            ProductName = name;
            Porcentage = porce;
        }
    }
}
