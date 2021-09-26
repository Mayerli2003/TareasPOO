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

namespace CalcularNotas
{
    public partial class PromedioGeneral : Form
    {

        public PromedioGeneral()
        {
            InitializeComponent();
        }



        private void PromedioBDatos_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void EnviarPromedio_Click(object sender, EventArgs e )
        {
            
            Notas notas = new Notas();
            ClsNotas clsNotas = new ClsNotas();
            notas.POO = Convert.ToDouble(txtPromedioPOO.Text);
            notas.Matemática = Convert.ToDouble(PromedioMatemática.Text);
            notas.BaseDatos = Convert.ToDouble(PromedioBDatos.Text);
            notas.Psicología = Convert.ToDouble(textPromedioPsicologia.Text);
            notas.SoftwareUtilitario = Convert.ToDouble(PromedioSoftware.Text);
            //String nombre = clsPersona.MostrarNombre(persona);
            String promedio = clsNotas.NotaGeneral(notas);


            MessageBox.Show(promedio);
        }

        private void CerrarPG_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Atrás_Click(object sender, EventArgs e)
        {
            VistasMaterias vistasMaterias = new VistasMaterias();
            vistasMaterias.Show();
        }
    }
}
