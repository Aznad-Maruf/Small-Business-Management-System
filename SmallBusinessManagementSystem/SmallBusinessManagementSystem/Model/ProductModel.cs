using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBusinessManagementSystem.Model
{
    public class ProductModel
    {
        public string Category { set; get; }
        public string Code { set; get; }
        public string Name { set; get; }
        public int ReorderLevel { set; get; }
        public string Description { set; get; }
    }
}
