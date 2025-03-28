using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlGen
{
    public partial class Zad2 : Form
    {
        public Zad2()
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
                    zdMin = 0;
                    zdMax = 3;
                    specimenCount = int.Parse(textSpecimen.Text);
                    paramCount = 3;
                    bitsForParam = int.Parse(textChromosom.Text);
                    competitionSize = int.Parse(textCompetition.Text);
                    iters = int.Parse(textIterate.Text);
                    
                    (double[] xValues, double[] yValues) = Tools.LoadFileEx2("sinusik.txt");
                    
                    var specimenPopulation = new List<Specimen>();
                    for (int i = 0; i < specimenCount; i++)
                    {
                        specimenPopulation.Add(Tools.Generate(paramCount, bitsForParam));
                        specimenPopulation[i].par = Tools.Decode(zdMin, zdMax, bitsForParam, paramCount, specimenPopulation[i].bits);
                        specimenPopulation[i].CountFunc2(xValues, yValues);
                    }
                    
                    var bestSpecimen = Specimen.BestSpecimenLowest(specimenPopulation).Clone();
                    var mean = Specimen.CountMean(specimenPopulation);
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