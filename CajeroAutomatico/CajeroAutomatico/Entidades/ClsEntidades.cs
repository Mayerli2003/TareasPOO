using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CajeroAutomatico.Entidades
{
    class ClsEntidades
    {
        private int dato;
        private int x;

        public ClsEntidades() { }
        public ClsEntidades(int dato, int x)
        {
            this.dato = dato;
            this.x = x;
        }

        public int Dato { get => dato; set => dato = value; }
        public int X { get => x; set => x = value; }
    }
}
