using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SmallBusinessManagementSystem.Model;

namespace SmallBusinessManagementSystem.Model
{
    public class PurchaseDetails
    {
        public int SI { get; set; }
        public string Product { get; set; }
        public string ManufacturedDate { get; set; }
        public string ExpiredDate { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public double MRP { get; set; }
        public string Remarks { get; set; }
        public string Edit { get; set; }
        public string Delete { get; set; }

        public string InvoiceNo { get; set; }
        public string Date { get; set; }
        public string Supplier { get; set; }
        public string Category { get; set; }
    }
}
