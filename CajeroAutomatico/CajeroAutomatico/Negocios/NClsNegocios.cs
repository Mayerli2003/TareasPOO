using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CajeroAutomatico.Entidades;

namespace CajeroAutomatico.Negocios
{
    class NClsNegocios
    {
        
        
        public String Datos(int dato)
        {
            if (dato % 5 == 0)
            {

                return("Puede sacar su dinero"+
                    "\n $"+dato);
            }
            else
            {

                return("Error no puede sacar su dinero");
            }
        }
    }
}
