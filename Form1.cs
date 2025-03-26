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
        
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            zad1 Zad1 = new zad1();
            Zad1.Show();
        }
    }
}