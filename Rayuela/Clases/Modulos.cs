using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    public class Modulos
    {
        private string idModulo;
        private string ciclo;
        private int curso;
        private string nombreCompleto;
        public Modulos() 
        {

        }

        public Modulos(string idModulo, string ciclo, int curso, string nombreCompleto)
        {
            this.IdModulo = idModulo;
            this.Ciclo = ciclo;
            this.Curso = curso;
            this.NombreCompleto = nombreCompleto;
        }

        public string IdModulo { get => idModulo; set => idModulo = value; }
        public string Ciclo { get => ciclo; set => ciclo = value; }
        public int Curso { get => curso; set => curso = value; }
        public string NombreCompleto { get => nombreCompleto; set => nombreCompleto = value; }
    }
}
