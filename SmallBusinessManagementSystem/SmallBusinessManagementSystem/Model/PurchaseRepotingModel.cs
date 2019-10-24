using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystem.Model
{
    public class PurchaseRepotingModel
    {

        public string Date { set; get; }
        public string Date2 { set; get; }
        public string Code { get; set; }
        public string Product { get; set; }
        public string Category { get; set; }
  

        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double MRP { get; set; }
        public double Profit { get; set; }
    }
}
