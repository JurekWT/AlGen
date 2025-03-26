using System;

namespace AlGen
{
    public class Specimen
    {
        public string bits;
        public double[] par;
        public double mean;

        public Specimen(string bits)
        {
            this.bits = bits;
        }

        public void CountMean()
        {
            double sum = 0;
            foreach (var value in par)
            {
                sum += value;
            }
            mean = sum / par.Length;
        }
    }
}