using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    public partial class Faltas
    {
        private int indice;
        private int IdentificadorAlumno;
        private DateTime fecha;
        private string modulo;

        public Faltas() 
        {

        }

        public Faltas(int indice, int identificadorAlumno, DateTime fecha, string modulo)
        {
            this.Indice = indice;
            this.IdentificadorAlumno1 = identificadorAlumno;
            this.Fecha = fecha;
            this.Modulo = modulo; 
        }

        public int Indice { get => indice; set => indice = value; }
        public int IdentificadorAlumno1 { get => IdentificadorAlumno; set => IdentificadorAlumno = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Modulo { get => modulo; set => modulo = value; }
    }
}
