using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_13Operadores
{
    class CEstudiante
    {
        private string nombre;
        private int id;
      
        public CEstudiante(string pNombre,  int pId)
        {
            nombre = pNombre;          
            id = pId;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Id { get => id; set => id = value; }
       

        public override string ToString()
        {
            return string.Format("Nombre: {0}, Id:{1}", nombre, id);
        }
    }

    class CCurso
    {
        private string curso;
        private int id;

        public CCurso(string curso, int id)
        {
            this.curso = curso;
            this.id = id;
        }

        public string Curso { get => curso; set => curso = value; }
        public int Id { get => id; set => id = value; }

        public override string ToString()
        {
            return string.Format("Curso: {0}, Id:{1}", curso, id);
        }
    }
}
