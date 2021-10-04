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
    public partial class FrmDivision : Form
    {
        public FrmDivision()
        {
            InitializeComponent();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            try
            {


                Double Operacion1 = Convert.ToDouble(Valor1.Text);
                Double Operacion2 = Convert.ToDouble(Valor2.Text);
                Operaciones operaciones = new Operaciones(Operacion1, Operacion2);
                ClsOperaciones clsOperaciones = new ClsOperaciones();



                //double respuesta = clsOperaciones.resta(operaciones);

                MessageBox.Show("La respuesta de la division " + Operacion1 + " / " + Operacion2 + " es de: " + clsOperaciones.division(operaciones));



            }
            catch (Exception ex)
            {
                MessageBox.Show("Operacion incompleta");

            }
            
        }
    }
}
