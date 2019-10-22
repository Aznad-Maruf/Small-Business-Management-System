using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystem.Model
{
    public class ProductDetails
    {
        public int SI { get; set; }
        public string Product { get; set; }
        public double Quantity { get; set; }
        public string Category { get; set; }
        public double MRP { get; set; }
        public double TotalMrp { get; set; }
        public string Edit { get; set; }
        public string Delete { get; set; }
        public SalesModel SalesModel;

    }
}
