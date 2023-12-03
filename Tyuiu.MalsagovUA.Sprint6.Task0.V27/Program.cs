using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.MalsagovUA.Sprint6.Task0.V27.Lib;
namespace Tyuiu.MalsagovUA.Sprint6.Task0.V27
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
            Application.Run(new x());
        }
    }
}
