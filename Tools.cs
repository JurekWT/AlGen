using System;
using System.Linq;
using System.Text;

namespace AlGen
{
    public class Tools
    {
        static Random random = new Random();
        public static double[] Decode(int zdMin, int zdMax, int bitsForParam, int paramCount, string bits)
        {
            
            double[] result = new double[paramCount];
            return result;
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
    }
}