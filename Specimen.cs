using System;
using System.Collections.Generic;
using System.Linq;

namespace AlGen
{
    public class Specimen
    {
        static Random random = new Random();
        public string bits;
        public double[] par;
        public double foo;

        public Specimen()
        {
        }

        public Specimen(string bits)
        {
            this.bits = bits;
        }
        public Specimen Clone()
        {
            return new Specimen
            {
                bits = string.Copy(this.bits),
                foo = this.foo,              
                par = (double[])this.par.Clone()
            };
        }

        public void CountFunc1()
        {
            double x1 = par[0];
            double x2 = par[1];
            foo = Math.Sin(x1 * 0.05) + Math.Sin(x2 * 0.05) + 0.4 * Math.Sin(x1 * 0.15) * Math.Sin(x2 * 0.15);
        }

        public void CountFunc2(double[] x1, double[] x2)
        {
            double result = 0;
            for (int i = 0; i < x1.Length; i++)
            {
                double specimenValue = par[0] * Math.Sin(par[1] * x1[i] + par[2]);
                result += Math.Pow(specimenValue - x2[i], 2);
            }

            foo = result;
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
            List<Specimen> temp = new List<Specimen>(specimens);
            Specimen bestSpecimen = temp.OrderByDescending(s => s.foo).First().Clone();
            return bestSpecimen;
        }

        public static Specimen BestSpecimenLowest(List<Specimen> specimens)
        {
            List<Specimen> temp = new List<Specimen>(specimens);
            Specimen bestSpecimen = temp.OrderBy(s => s.foo).First().Clone();
            return bestSpecimen;
        }

        public void Mutate()
        {
            int pointOfMutation = random.Next(0, bits.Length);
            char[] chars = bits.ToCharArray();
            chars[pointOfMutation] = chars[pointOfMutation] == '0' ? '1' : '0';
            bits = new string(chars);
        }

        public static void Crossover(Specimen specimen1, Specimen specimen2)
        {
            var pointOfCrossover = random.Next(0, specimen1.bits.Length - 2);
            var specimen1Part1 = specimen1.bits.Substring(0, pointOfCrossover);
            var specimen1Part2 = specimen1.bits.Substring(pointOfCrossover);
            var specimen2Part1 = specimen2.bits.Substring(0, pointOfCrossover);
            var specimen2Part2 = specimen2.bits.Substring(pointOfCrossover);
            specimen1.bits = specimen1Part1 + specimen2Part2;
            specimen2.bits = specimen2Part1 + specimen1Part2;
        }
    }
}