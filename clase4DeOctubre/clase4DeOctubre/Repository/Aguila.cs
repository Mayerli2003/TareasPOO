using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase4DeOctubre
{
    class Aguila : IVolador
    {
        public void comer()
        {
            MessageBox.Show("El aguila esta comiendo");
        }

        public void Volar()
        {
            MessageBox.Show("El aguila esta volando");
        }
    }
}
