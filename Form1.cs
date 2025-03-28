using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AlGen
{
    public partial class AlgorytmGenetyczny : Form
    {
        public AlgorytmGenetyczny()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            zad1 Zad1 = new zad1();
            this.Hide();
            Zad1.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Zad2 Zad2 = new Zad2();
            this.Hide();
            Zad2.ShowDialog();
            this.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Zad3 Zad3 = new Zad3();
            this.Hide();
            Zad3.ShowDialog();
            this.Show();
        }
    }
}