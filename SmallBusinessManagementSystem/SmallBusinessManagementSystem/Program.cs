using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
<<<<<<< HEAD
            Application.Run(new SalesUI());
=======
            Application.Run(new SalesUI());           
>>>>>>> 3dc93cd93607f453b69ad632caba42802f69e0f8
            Application.Run(new SupplierEntryUI());
        }
    }
}
