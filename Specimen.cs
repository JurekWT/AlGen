using System;

namespace AlGen
{
    public class Specimen
    {
        public string bits;
        public double[] par;

        public Specimen(string bits)
        {
            this.bits = bits;
        }

        public double CountMean()
        {
            double sum = 0;
            foreach (var value in par)
            {
                sum += value;
            }
            return sum / par.Length;
        }
    }
}