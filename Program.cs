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
            
            List<Specimen> specimens = new List<Specimen>();
            for (int i = 0; i < specimenCount; i++)
            {
                specimens.Add(Tools.Generate(paramCount, bitsForParam));
            }

            foreach (var specimen in specimens)
            {
                specimen.par = Tools.Decode(zdMin, zdMax, bitsForParam, paramCount, specimen.bits);
                specimen.CountMean();
            }
            MessageBox.Show($"{specimens[1].bits} - {specimens[1].par[0]} - {specimens[1].par[1]}\n" +
                            $"{specimens[1].mean}");
            
        }
    }
}