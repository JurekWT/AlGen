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
                    double mean;
                    Specimen best;
                    List<Specimen> specimens = new List<Specimen>();
                    for (int i = 0; i < specimenCount; i++)
                    {
                        specimens.Add(Tools.Generate(paramCount, bitsForParam));
                    }

                    foreach (var specimen in specimens)
                    {
                        specimen.par = Tools.Decode(zdMin, zdMax, bitsForParam, paramCount, specimen.bits);
                        specimen.CountFunc1();
                    }
                     mean = Specimen.CountMean(specimens);
                     best = Specimen.BestSpecimenHighest(specimens);
                     textOutput.Text += $"Najlepszy: {best.bits} - Funkcja przystosowania {best.foo:F2} \r\n" +
                                        $"Średnia funkcja przystosowania {mean:F2}";
                     

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