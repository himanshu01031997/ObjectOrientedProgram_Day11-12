using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement
{
    public class Inventory//model class
    {
        public List <StockAccount> stockAccount;
 
    }
    public class StockAccount
    {
        public string stockname { get; set; }
        public int ShareNo { get; set; }
        public int Shareprice { get; set; }

    }
}
