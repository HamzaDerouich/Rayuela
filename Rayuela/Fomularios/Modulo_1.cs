using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    public class Modulo
    {
        private int indice;
        private int identificadorAlumno;
        private DateTime fecha;
        private string modulo;

        public Modulo() 
        {

        }

        public Modulo(int indice, int identificadorAlumno, DateTime fecha, string modulo)
        {
            this.Indice = indice;
            this.IdentificadorAlumno = identificadorAlumno;
            this.Fecha = fecha;
            this.Modulo = modulo;
        }

        public int Indice { get => indice; set => indice = value; }
        public int IdentificadorAlumno { get => identificadorAlumno; set => identificadorAlumno = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Modulo { get => modulo; set => modulo = value; }
    }
}
