using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Alex_Gheorghita___Software_Programming_Project
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
            string readInitialization = File.ReadAllText("initialization.txt");
            if (readInitialization == "true")
            {
                Application.Run(new Form2());
            } else
            {
                Application.Run(new Form1());
            }
        }
    }
}
