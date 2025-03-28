using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AlGen
{
    public class Tools
    {
        static Random random = new Random();
        public static double[] Decode(int zdMin, int zdMax, int bitsForParam, int paramCount, string bits)
        {
            int zd = zdMax - zdMin;
            Dictionary<string, double> decodeTable = new Dictionary<string, double>();
            for (int i = 0; i < Math.Pow(2, bitsForParam); i++)
            {
                string key = Convert.ToString(i, 2).PadLeft(bitsForParam, '0');
                decodeTable[key] = zdMin + (i / (Math.Pow(2, bitsForParam) - 1)) * zd;
            }
            List<string> param = CutString(bits, bitsForParam);
            double[] result = new double[paramCount];
            for (int i = 0; i < param.Count; i++)
            {
                result[i] = decodeTable[param[i]];
            }
            return result;
        }

        public static List<string> CutString(string bits, int sliceSize)
        {
            List<string> temp = new List<string>();
            for (int i = 0; i < bits.Length; i += sliceSize)
            {
                string slice = bits.Substring(i, Math.Min(bits.Length - i, sliceSize));
                temp.Add(slice);
            }
            return temp;
        }
        
        public static Specimen Generate(int paramCount, int bitsForParam)
        {
            StringBuilder bits = new StringBuilder(paramCount*bitsForParam);
            for (int i = 0; i < paramCount*bitsForParam; i++)
            {
                bits.Append(random.Next(0, 2).ToString());
            }
            Specimen specimen = new Specimen(bits.ToString());
            return specimen;
        }

        public static Specimen CompetitionHighest(List<Specimen> specimens, int compSize)
        {
            List<Specimen> specimens2 = new List<Specimen>(specimens);
            List<Specimen> temp2 = new List<Specimen>();
            int number;
            for (int i = 0; i < compSize; i++)
            {
                number = random.Next(0, specimens2.Count);
                temp2.Add(specimens2.ElementAt(number));
                specimens2.RemoveAt(number);
            }
            Specimen winner = temp2.OrderByDescending(s => s.foo).First();
            return winner;
        }

        public static (double[] xValues, double[] yValues) LoadFileEx2(string filename)
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            double[] xValues = new double[lines.Length];
            double[] yValues = new double[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] values = lines[i].Trim().Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                xValues[i] = double.Parse(values[0], NumberStyles.Float, CultureInfo.InvariantCulture);
                yValues[i] = double.Parse(values[1], NumberStyles.Float, CultureInfo.InvariantCulture);
            }
            return (xValues, yValues);
        }
    }
}
