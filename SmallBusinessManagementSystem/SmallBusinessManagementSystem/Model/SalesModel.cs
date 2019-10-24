using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystem.Model
{
    public class SalesModel
    {
        public int SalesCode { get; set; }
        public string Date { get; set; }
        public string Customer { get; set; }
        public string Category { get; set; }
        public string Product { get; set; }
        public double Quantity { get; set; }
        public double MRP { get; set; }
    }
}
