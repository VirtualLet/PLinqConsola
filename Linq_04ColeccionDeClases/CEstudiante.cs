using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_04ColeccionDeClases
{
    class CEstudiante
    {
        private string nombre;
        private string id;
        private string curso;
        private double promedio;

        public CEstudiante(string pNombre, string pId, string pCurso, double pPromedio)
        {
            nombre = pNombre;
            id = pId;
            curso = pCurso;
            promedio = pPromedio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Id { get => id; set => id = value; }
        public string Curso { get => curso; set => curso = value; }
        public double Promedio { get => promedio; set => promedio = value; }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, Id:{1}, Curso:{2}, Promedio:{3}", nombre, id, curso, promedio);
        }
    }
}
