using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlGen
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
            Application.Run(new AlgorytmGenetyczny());
            int specimenCount = 9;
            int paramCount = 4;
            int bitsForParam = 5;
            int zdMin = 0;
            int zdMax = 3;
            
            
        }
    }
}