using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmallBusinessManagementSystem.Model;
using SmallBusinessManagementSystem.UI;

namespace SmallBusinessManagementSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new SalesUI());
            //Application.Run(new CategoryUI());
            //Application.Run(new ProductUI());
            Application.Run(new CustomerUI());
        }
    }
}
