using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcularNotas.Entidades;
using CalcularNotas.Negocio;
using CalcularNotas.Vistas;

namespace CalcularNotas
{
    
    public partial class VistasMaterias : Form
    {
        public VistasMaterias()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void Software_Click_1(object sender, EventArgs e)
        {
            VistasDatos vistas = new VistasDatos();
            vistas.Show();
            



        }



        private void POO_Click(object sender, EventArgs e)
        {
            VistasDatos vistas = new VistasDatos();
            vistas.Show();

        }

        private void BDatos_Click(object sender, EventArgs e)
        {
            VistasDatos vistas = new VistasDatos();
            vistas.Show();

        }

        private void Psicología_Click(object sender, EventArgs e)
        {
            VistasDatos vistas = new VistasDatos();
            vistas.Show();

        }

        private void Matemática_Click(object sender, EventArgs e)
        {
            VistasDatos vistas = new VistasDatos();
            vistas.Show();

        }

        private void PromedioGeneral_Click(object sender, EventArgs e)
        {
            PromedioGeneral promedio = new PromedioGeneral();
            promedio.Show();
        }

        private void MateriasCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
