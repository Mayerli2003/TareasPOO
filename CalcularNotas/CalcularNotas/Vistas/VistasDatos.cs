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

namespace CalcularNotas.Vistas
{
    public partial class VistasDatos : Form
    {
        public VistasDatos()
        {
            InitializeComponent();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            Notas notas = new Notas();
            ClsNotas clsNotas = new ClsNotas();
            notas.Laboratorio1 = double.Parse(Laboratorio1.Text);
            notas.Laboratorio2 = double.Parse(Laboratorio2.Text);
            notas.Laboratorio3 = double.Parse(Laboratorio3.Text);
            notas.Parcial1 = double.Parse(Parcial1.Text);
            notas.Parcial2 = double.Parse(Parcial2.Text);
            notas.Parcial3 = double.Parse(Parcial3.Text);
            String promedio = clsNotas.PromedioIndividual(notas);
            String comentario = clsNotas.mostrarnotas(notas);
            MessageBox.Show(promedio+
                "\n"+comentario);
            
            
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Atrás_Click(object sender, EventArgs e)
        {
            VistasMaterias vistas = new VistasMaterias();
            vistas.Show();
        }
    }
}
