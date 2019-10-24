using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystem.Model
{
    public class PurchaseModel
    {
        public string SI { get; set; }
        public string InvoiceNo { get; set; }
        public string Date { get; set; }
        public string Supplier { get; set; }
        public string Category { get; set; }
        public string Product { get; set; }
        public string ManufactureDate { get; set; }
        public string ExpireDate { get; set; }
        public double Quantity { get; set; }
        public double UnitPrice { get; set; }
        public double TotalPrice { get; set; }
        public double MRP { get; set; }
        public string Remarks { get; set; }
        public string Edit { get; set; } = "Edit";
        public string Delete { get; set; } = "Delete";

        public string Code { get; set; }
        public string AvailableQuantity { get; set; }
        public string PreviousUnitPrice { get; set; } = null;
        public string PreviousMRP { get; set; } = null;
    }
}
