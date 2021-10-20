using Estudiantes.Data;
using Estudiantes.Servise;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Estudiantes.Reposity
{
    class ClsREstudiante : IEstudiante
    {
        public void Create(estudiante estudientes)
        {
            throw new NotImplementedException();
        }

        public void Delete(estudiante estudiantes)
        {
            throw new NotImplementedException();
        }

        public List<estudiante> ListOfTableEstudiante()
        {
            using (EstudiantesEntities conexionBd = new EstudiantesEntities())
            {
                List<estusiante> ListaOfEstudiante = conexionBd.estudiante.ToList();
                //select * from estudiante
                return ListaOfEstudiante;

            }
        }

        public void uptate(estudiante estudiante)
        {
            throw new NotImplementedException();
        }
    }
}
