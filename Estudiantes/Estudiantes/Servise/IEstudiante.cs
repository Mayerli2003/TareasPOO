using Estudiantes.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estudiantes.Data;

namespace Estudiantes.Servise
{
    interface IEstudiante
    {
        //CRUD

        //C
        void Create(estudiante estudientes);
        //D
        void Delete(estudiante estudiantes);
        //U
        void uptate(estudiante estudiante);

        List<estudiante> ListOfTableEstudiante();
    }
}
