using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    public class Cursos
    {
        private string idCurso;
        private string nombreCompleto;
        private int curso;
        private string ciclo;

        public Cursos()
        {

        }

        public Cursos(string idCurso, string nombreCompleto, int curso, string ciclo)
        {
            this.IdCurso = idCurso;
            this.NombreCompleto = nombreCompleto;
            this.Curso = curso;
            this.Ciclo = ciclo;
        }

        public string IdCurso { get => idCurso; set => idCurso = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
        public int Curso { get => curso; set => curso = value; }
        public string Ciclo { get => ciclo; set => ciclo = value; }
    }
}
