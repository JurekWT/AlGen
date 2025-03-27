using System;
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

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
        }
    }
}