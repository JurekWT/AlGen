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
            List<Specimen> specimens = new List<Specimen>();
            for (int i = 0; i < 10; i++)
            {
                specimens.Add(Tools.Generate(10, 3));
            }
            
        }
    }
}