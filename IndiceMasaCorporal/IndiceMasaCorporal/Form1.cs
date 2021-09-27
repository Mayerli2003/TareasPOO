using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IndiceMasaCorporal.Entidades;
using IndiceMasaCorporal.Negocio;

namespace IndiceMasaCorporal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            ClsPersona clsPersona = new ClsPersona();
            persona.Nombre = nombre.Text;
            persona.Edad = int.Parse(edad.Text);
            persona.Sexo = sexo.Text;
            persona.Altura = Convert.ToDouble(altura.Text);
            persona.Peso = Convert.ToDouble(peso.Text);
            String tostring = clsPersona.ToString(persona);
            MessageBox.Show(tostring);
            String edadmayor = clsPersona.esMayorDeEdad(persona);
            MessageBox.Show(edadmayor);
            String IMC = clsPersona.CalculoIMC(persona);
            MessageBox.Show(IMC);

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
