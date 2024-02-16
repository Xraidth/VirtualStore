using DB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DataConfig
    {
        static public void ConfigDB()
        {
            using (var context = virtual_storeContext.CreateContext())
            {
                context.EnsureDatabaseCreated();
            }
        }
    }
}
