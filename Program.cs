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
            int paramCount = 2;
            int bitsForParam = 3;
            int zdMin = 0;
            int zdMax = 3;
            
            List<Specimen> specimens = new List<Specimen>();
            for (int i = 0; i < specimenCount; i++)
            {
                specimens.Add(Tools.Generate(paramCount, bitsForParam));
            }
            specimens[1].par = Tools.Decode(zdMin, zdMax, bitsForParam, paramCount, specimens[1].bits);
            MessageBox.Show(specimens[1].bits);
            
        }
    }
}