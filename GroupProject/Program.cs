using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            EventCoordinator custManager = new EventCoordinator(1, 1000, 1, 5000,1,5000);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu(custManager));
           //application.Run(new customerOptions(custManager));
        } 
    }
}
