using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estudiante.Data;
using Estudiante.Service;

namespace Estudiante.Repository
{
    class ClsREstudiante : IEstudiante
    {
        public void Create(estudiante estudiante)
        {
            using (EstudiantesEntities conexionBD = new EstudiantesEntities()) {
                try
                {
                    estudiante est = new estudiante();
                    est.nombresEstudiante = estudiante.nombresEstudiante;
                    est.apellidos = estudiante.apellidos;
                    est.usuario = estudiante.usuario;
                    est.contrasenia = estudiante.contrasenia;

                    conexionBD.estudiante.Add(est);
                    conexionBD.SaveChanges();
                    

                }catch(Exception ex)
                {
                    MessageBox.Show("Error de base de datos " + ex);
                } 
            }
            
        }

        public void Delate(estudiante estudiante)
        {
            throw new NotImplementedException();
        }
    }
}
