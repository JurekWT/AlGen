using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlGen
{
    public partial class Zad3 : Form
    {
        public Zad3()
        {
            InitializeComponent();
        }
        private int specimenCount;
        private int paramCount;
        private int bitsForParam;
        private int zdMin;
        private int zdMax;
        private int iters;
        private int competitionSize;

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            try
            {
                if (textChromosom.Text == "" || textIterate.Text == "" || int.Parse(textChromosom.Text) < 4 ||
                    int.Parse(textIterate.Text) < 100)
                {
                    MessageBox.Show("Wprowadź poprawne wartości");
                }
                else
                {
                    zdMin = -10;
                    zdMax = 10;
                    specimenCount = int.Parse(textSpecimen.Text);
                    paramCount = 9;
                    bitsForParam = int.Parse(textChromosom.Text);
                    competitionSize = int.Parse(textCompetition.Text);
                    iters = int.Parse(textIterate.Text);

                    var xorInput = new double[,] { { 0, 0 }, { 0, 1 }, { 1, 0 }, { 1, 1 } };
                    var xorOutput = new double[] { 0, 1, 1, 0 };
                    
                    var specimenPopulation = new List<Specimen>();
                    for (int i = 0; i < specimenCount; i++)
                    {
                        specimenPopulation.Add(Tools.Generate(paramCount,bitsForParam));
                        specimenPopulation[i].par = Tools.Decode(zdMin, zdMax, bitsForParam, paramCount, specimenPopulation[i].bits);
                        specimenPopulation[i].CountFunc3(xorInput, xorOutput);
                    }
                    var bestSpecimen = Specimen.BestSpecimenLowest(specimenPopulation).Clone();
                    var mean = Specimen.CountMean(specimenPopulation);
                    textOutput.Text = $"Najlepszy: {bestSpecimen.foo:F2}" + Environment.NewLine +
                                      $"Średnia funkcja przystosowania: {mean:F2}" + Environment.NewLine;
                    
                    for (int i = 0; i < iters; i++)
                    {
                        var specimenNewGeneration = new List<Specimen>();
                        textOutput.Text += $"Iteracja {i + 1}" + Environment.NewLine;
                        for (int j = 0; j < specimenPopulation.Count - 1; j++)
                        {
                            var child = Tools.CompetitionLowest(specimenPopulation, competitionSize);
                            specimenNewGeneration.Add(child.Clone());
                        }
                        Specimen.Crossover(specimenNewGeneration[0], specimenNewGeneration[1]);
                        Specimen.Crossover(specimenNewGeneration[2], specimenNewGeneration[3]);
                        Specimen.Crossover(specimenNewGeneration[8], specimenNewGeneration[9]);
                        Specimen.Crossover(specimenNewGeneration[10], specimenNewGeneration[11]);
                        for (int j = 4; j < specimenNewGeneration.Count; j++)
                        {
                            specimenNewGeneration[j].Mutate();
                        }

                        foreach (var specimen in specimenNewGeneration)
                        {
                            specimen.par = Tools.Decode(zdMin, zdMax, bitsForParam, paramCount, specimen.bits);
                            specimen.CountFunc3(xorInput, xorOutput);
                        }
                        specimenNewGeneration.Add(bestSpecimen);
                        specimenPopulation = new List<Specimen>(specimenNewGeneration);
                        bestSpecimen = Specimen.BestSpecimenLowest(specimenPopulation).Clone();
                        mean = Specimen.CountMean(specimenPopulation);
                        textOutput.Text += $"Najlepszy: {bestSpecimen.foo:F2}" + Environment.NewLine +
                                           $"Średnia funkcji przystosowania: {mean}" + Environment.NewLine;

                    }
                }
            }
            catch (Exception er)
            {
                Console.WriteLine(er);
                throw;  
            }
        }

        private void textChromosom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textIterate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}