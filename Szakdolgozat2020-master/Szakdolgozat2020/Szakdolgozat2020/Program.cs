using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Szakdolgozat2020.Forms;
using Szakdolgozat2020.Forms.Foster;
using Szakdolgozat2020.Forms.Soul;

namespace Szakdolgozat2020
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LogInScreen());
        }
    }
}
