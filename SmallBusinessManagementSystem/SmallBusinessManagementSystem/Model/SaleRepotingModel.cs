using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystem.Model
{
    public class SaleRepotingModel
    {
        public string Date { set; get; }
        public string Date2 { set; get; }
        
        
        public string Category { get; set; }
        public string Product { get; set; }
        
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double MRP { get; set; }
        public double Profit { get; set; }

    }
}
