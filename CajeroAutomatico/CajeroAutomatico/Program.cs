using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  CajeroAutomatico.Entidades;
using  CajeroAutomatico.Negocios;

namespace CajeroAutomatico
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            
            
            Console.WriteLine("Coloca un valor a sacar tu dinero");
            int dato = Convert.ToInt32(Console.ReadLine());
            ClsEntidades entidades = new ClsEntidades();
            NClsNegocios negocios = new NClsNegocios();



            Console.WriteLine(negocios.Datos(dato));
            Console.ReadLine();


        }
    }
}
