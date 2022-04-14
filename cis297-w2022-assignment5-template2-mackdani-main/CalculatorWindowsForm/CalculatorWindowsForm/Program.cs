using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorWindowsForm
{
    internal static class Program
    {
        /// <summary>
        /// This program implements some arithmetic functions as a calculator
        /// And uses the Window Forms App to perform the functions of a calculator
        /// </summary>
        /// <Student>Daniel Mack</Student>
        /// <Class>CIS297</Class>
        /// <Semester>Winter 2022</Semester>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalculatorForm1());
        }
    }
}
