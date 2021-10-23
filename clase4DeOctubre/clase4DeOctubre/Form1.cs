using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase4DeOctubre
{
    public partial class Form1 : Form
    {
        Aveja aveja = new Aveja();
        Aguila aguila = new Aguila();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            aveja.comer();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            aguila.comer();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            aveja.Volar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            aguila.Volar();
        }
    }
}
