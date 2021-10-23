using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudiante.Data;

namespace Estudiante.Service
{
    interface IEstudiante
    {
        //CRUD
        //C
        void Create(estudiante estudiante);

        //D
        void Delate(estudiante estudiante);
    }
}
