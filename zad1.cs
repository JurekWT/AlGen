using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace AlGen
{
    public partial class zad1 : Form
    {
        private int specimenCount;
        private int paramCount;
        private int bitsForParam;
        private int zdMin;
        private int zdMax;
        private int iters;
        
        public zad1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textOsob.Text == "" || textIter.Text == "" || textChrom.Text == "" || textTurn.Text == "" ||
                    int.Parse(textOsob.Text) < 9 || int.Parse(textOsob.Text)%2 == 0 || int.Parse(textIter.Text) < 20 ||
                    int.Parse(textChrom.Text) < 3 || int.Parse(textTurn.Text) < 2 || int.Parse(textTurn.Text) > 20 )
                {
                    MessageBox.Show("Wprowadź poprawne wartości");
                }
                else
                {
                    textOutput.Text = "";
                    zdMin = 0;
                    zdMax = 100;
                    paramCount = 2;
                    specimenCount = int.Parse(textOsob.Text);
                    bitsForParam = int.Parse(textChrom.Text);
                    iters = int.Parse(textIter.Text);
                    double pct = double.Parse(textTurn.Text) / 100.0;
                    int turn;
                    double mean;
                    Specimen best;

                    turn = (int)(specimenCount * pct);
                    if (turn < 2)
                    {
                        turn = 2;
                    }
                    
                    List<Specimen> specimens = new List<Specimen>();
                    for (int i = 0; i < specimenCount; i++)
                    {
                        specimens.Add(Tools.Generate(paramCount, bitsForParam));
                        specimens[i].par = Tools.Decode(zdMin, zdMax, bitsForParam, paramCount, specimens[i].bits);
                        specimens[i].CountFunc1();
                    }

                    mean = Specimen.CountMean(specimens);
                    best = Specimen.BestSpecimenHighest(specimens);
                    textOutput.Text += $"Najlepszy: {best.bits} - Funkcja przystosowania {best.foo:F2} \r\n" +
                                       $"Średnia funkcja przystosowania {mean:F2}\r\n";
                    int count = 0;
                    while (count != iters)
                    {
                        List<Specimen> nextGen = new List<Specimen>();
                        for (int i = 0; i < specimens.Count - 1; i++)
                        {
                            Specimen child = Tools.CompetitionHighest(specimens, turn);
                            child.Mutate();
                            child.par = Tools.Decode(zdMin, zdMax, bitsForParam, paramCount, child.bits);
                            child.CountFunc1();
                            nextGen.Add(child);
                        }
                        nextGen.Add(best);
                        specimens = new List<Specimen>(nextGen);
                        best = Specimen.BestSpecimenHighest(specimens).Clone();
                        mean = Specimen.CountMean(specimens);
                        textOutput.Text += $"Iteracja {count+1} \r\n" +
                                           $"Najlepszy: {best.bits} - Funkcja przystosowania: {best.foo:F2}\r\n" +
                                           $"Średnia funkcja przystosowania {mean:F2}\r\n";
                        count++;
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private void textOsob_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textChrom_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textTurn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textIter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}