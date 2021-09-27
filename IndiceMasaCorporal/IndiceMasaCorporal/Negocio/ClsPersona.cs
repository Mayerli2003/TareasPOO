using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IndiceMasaCorporal.Entidades;

namespace IndiceMasaCorporal.Negocio
{
    class ClsPersona
    {
        public String CalculoIMC(Persona persona)
        {
            double resultado;
            resultado = persona.Peso /(persona.Altura* persona.Altura);
            
            if (resultado < 18.5)
            {
                return "Hola " + persona.Nombre + " su IMC es de:" + resultado +
                    "\nSu peso esta bajo";
            }
            if (resultado > 18.5 & resultado < 24.9)
            {
                return "Hola " + persona.Nombre + " su IMC es de:" + resultado +
                    "\nSu peso es el ideal";
            }
            if (resultado > 24.9 & resultado < 30)
            {
                return "Hola " + persona.Nombre + " su IMC es de:" + resultado +
                    "\nTiene sobrepeso";
            }
            else
            {
                return "Hola " + persona.Nombre + " su IMC es de:" + resultado +
                    "\nTiene obesidad";
            }
        }



        public String esMayorDeEdad(Persona persona)
        {
            if (persona.Edad > 17)
            {
                return ("Eres mayor de edad.");
            }
            else
            {
                return ("Eres menor de edad.");
            }
        }
        public string ToString(Persona persona)
        {
            return "Nombre: " + persona.Nombre +
                "\n Edad: " + persona.Edad +
                "\n Sexo: " + persona.Sexo +
                "\n Peso: " + persona.Peso+
                "\n Altura: " + persona.Altura;
        }

    }
}
