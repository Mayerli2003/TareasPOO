using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcularNotas.Entidades;

namespace CalcularNotas.Negocio
{
    class ClsNotas
    {
        public string mostrarnotas(Notas notas )
        {
            return "Las notas ingresadas son: "+
                "\nPrimer laboratorio: "+notas.Laboratorio1 +
                "\nPrimer parcial: "+notas.Parcial1 +
                "\nSegundo laboratorio: "+notas.Laboratorio2 +
                "\nSegundo parcial: "+notas.Parcial2+
                "\nTercer laboratorio: "+notas.Laboratorio3 +
                "\nTercer parcial: "+notas.Parcial3;

        }
        
        public string PromedioIndividual(Notas notas)
        {
            double promedio;
            promedio = ((notas.Laboratorio1 + notas.Laboratorio2 + notas.Laboratorio3) / 3 * 0.40) + ((notas.Parcial1 + notas.Parcial2 + notas.Parcial3) / 3 * 0.60);

             return " El promedio de la materia es de:   " + promedio;
        }
        public string NotaGeneral(Notas promedioMaterias)
        {
            double respuesta;
            respuesta = ((promedioMaterias.BaseDatos + promedioMaterias.Matemática + promedioMaterias.POO + promedioMaterias.Psicología + promedioMaterias.SoftwareUtilitario)/5);
            return "El promedio general es de: " + respuesta;
        }

        
    }
}
