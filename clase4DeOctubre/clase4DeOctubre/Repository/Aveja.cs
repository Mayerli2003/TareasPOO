using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clase4DeOctubre
{
    class Aveja : IVolador
    {
        public void comer()
        {
            MessageBox.Show("La aveja esta comiendo");
        }

        public void Volar()
        {
            MessageBox.Show("La aveja esta volando");
        }
    }
}
