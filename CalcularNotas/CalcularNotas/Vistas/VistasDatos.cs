﻿using System;
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
            notas.Laboratorio1 = Convert.ToDouble(Laboratorio1.Text);
            notas.Laboratorio2 = Convert.ToDouble(Laboratorio2.Text);
            notas.Laboratorio3 = Convert.ToDouble(Laboratorio3.Text);
            notas.Parcial1 = Convert.ToDouble(Parcial1.Text);
            notas.Parcial2 = Convert.ToDouble(Parcial2.Text);
            notas.Parcial3 = Convert.ToDouble(Parcial3.Text);
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
