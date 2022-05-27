using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robert_Dickerson___InventorySystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //this will format my datetimes
            CultureInfo culture = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            culture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd, HH:mm:ss";
            culture.DateTimeFormat.LongTimePattern = "";
            Thread.CurrentThread.CurrentCulture = culture;

            // This will populate the datagridviews at run.

            Inventory.AllParts.Add(new Inhouse(111, "Test_InHouse", 19.99, 1, 1, 99, 12345));
            Inventory.AllParts.Add(new Outsourced(112, "Test_Outsourced", 19.99, 1, 1, 99, "ABCDE"));
            Inventory.AllParts.Add(new Inhouse(113, "Test_InHouse2", 19.99, 1, 1, 99, 123456));
            Inventory.AllParts.Add(new Outsourced(114, "Test_Outsourced2", 19.99, 1, 1, 99, "ABCDEF"));

            BindingList<Part> bList = new BindingList<Part>();
            bList.Add(Inventory.AllParts[0]);
            Product product = new Product(113, "Test_Product", 19.99, 1, 1, 99, bList);
            Inventory.Products.Add(product);


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInScreen());

            

        }
    }
}
