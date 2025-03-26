using System;
using System.Collections.Generic;
using System.Linq;

namespace AlGen
{
    public class Specimen
    {
        public string bits;
        public double[] par;
        public double foo;

        public Specimen(string bits)
        {
            this.bits = bits;
        }

        public void CountFunc1()
        {
            double x1 = par[0];
            double x2 = par[1];
            foo = Math.Sin(x1 * 0.05) + Math.Sin(x2 * 0.05) + 0.4 * Math.Sin(x1 * 0.15) + Math.Sin(x2 * 0.15);
        }

        public static double CountMean(List<Specimen> specimens)
        {
            double sum = 0;
            foreach (var specimen in specimens)
            {
                sum += specimen.foo;
            }
            return sum / specimens.Count;
        }

        public static Specimen BestSpecimenHighest(List<Specimen> specimens)
        {
            Specimen bestSpecimen = specimens.OrderByDescending(s => s.foo).First();
            return bestSpecimen;
        }
    }
}