using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudiante.Service;
using Estudiante.Data;
using Estudiante.Repository;


namespace Estudiante.Negocio
{
    class ClsNegocio:ClsREstudiante
    {
        public void Guardar (estudiante es)
        {
            Create(es);
        }
    }
}
