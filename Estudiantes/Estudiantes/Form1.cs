using Estudiantes.Data;
using Estudiantes.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudiantes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            estudiante es = new estudiante();
            es.nombresEstudiante = textBox3.Text;
            ClsEstudiante clsEstudiante = new ClsEstudiante();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmVistaConsultaEstudiante formulario= 

        }
    }
}
