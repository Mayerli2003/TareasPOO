using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularNotas.Entidades
{
    class Notas
    {
        private double laboratorio1;
        private double parcial1;
        private double laboratorio2;
        private double parcial2;
        private double laboratorio3;
        private double parcial3;
        private double matemática;
        private double baseDatos;
        private double psicología;
        private double pOO;
        private double softwareUtilitario;



        public double Laboratorio1 { get => laboratorio1; set => laboratorio1 = value; }
        public double Parcial1 { get => parcial1; set => parcial1 = value; }
        public double Laboratorio2 { get => laboratorio2; set => laboratorio2 = value; }
        public double Parcial2 { get => parcial2; set => parcial2 = value; }
        public double Laboratorio3 { get => laboratorio3; set => laboratorio3 = value; }
        public double Parcial3 { get => parcial3; set => parcial3 = value; }
        public double Matemática { get => matemática; set => matemática = value; }
        public double BaseDatos { get => baseDatos; set => baseDatos = value; }
        public double Psicología { get => psicología; set => psicología = value; }
        public double POO { get => pOO; set => pOO = value; }
        public double SoftwareUtilitario { get => softwareUtilitario; set => softwareUtilitario = value; }
    }
}
