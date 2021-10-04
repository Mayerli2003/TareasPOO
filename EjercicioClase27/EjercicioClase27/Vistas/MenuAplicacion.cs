using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EjercicioClase27.Entidades;
using EjercicioClase27.Negocio;
using EjercicioClase27.Vistas;

namespace EjercicioClase27.Vistas
{
    public partial class MenuAplicacion : Form
    {
        public MenuAplicacion()
        {
            InitializeComponent();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formularioEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.MdiParent = this;
            estudiante.Show();
            
        }

        private void MenuAplicacion_Load(object sender, EventArgs e)
        {

        }

        private void restaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmResta frmResta = new FrmResta();
            frmResta.Show();

        }

        private void sumaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSuma frmSuma = new FrmSuma();
            frmSuma.Show();
        }

        private void multiplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMultiplicacion frmMultiplicacion = new FrmMultiplicacion();
            frmMultiplicacion.Show();
        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDivision frmDivision = new FrmDivision();
            frmDivision.Show();
        }
    }
}
