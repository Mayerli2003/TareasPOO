using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendasDonPepe.Entidades;



namespace TiendasDonPepe.Negocios

{
    
    class NClsProductos

    {
        ClsProductos productos = new ClsProductos();

        
        

        public double totalPagar(ClsProductos productos)
        {
            
            if (productos.Id== 2)
            {
                double Respuesta1;
                
                Respuesta1 =productos.Monto_precio * 0.15;
                productos.Total = productos.Monto_precio - Respuesta1;
                Console.WriteLine("El total es de $" + productos.Total+
                    "\nDescuento:");
                return Respuesta1;

            }
             else if (productos.Id == 4)
            {
                double Respuesta1;
                
                Respuesta1 = productos.Monto_precio * 0.15;
                productos.Total = productos.Monto_precio - Respuesta1;
                Console.WriteLine("El total es de $" + productos.Total+
                    "\nDescuento:");

                  return Respuesta1;
                



            }
            else
            {
                Console.WriteLine("El total a pagar es de $"+ productos.Monto_precio +
                    "\n Total sin descuento: ");
                
                  return   productos.Monto_precio;
            }


        }

    
    }
}
