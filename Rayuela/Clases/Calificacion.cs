using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    public class Calificacion
    {
        private int indice;
        private string identificador;
        private string modulo;
        private int puntos;
        private Dictionary<string, List<int>> notas;


        public Calificacion()
        {

        }

        public Calificacion(int indice, string identificador, string modulo, int puntos)
        {
            this.Indice = indice;
            this.Identificador = identificador;
            this.Modulo = modulo;
            this.Puntos = puntos;
            Notas = new Dictionary<string, List<int>>();
        }

        public int Indice { get => indice; set => indice = value; }
        public string Identificador { get => identificador; set => identificador = value; }
        public string Modulo { get => modulo; set => modulo = value; }
        public int Puntos { get => puntos; set => puntos = value; }
        public Dictionary<string, List<int>> Notas { get => notas; set => notas = value; }

    }
}
