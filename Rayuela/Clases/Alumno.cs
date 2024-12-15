using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rayuela
{
    public class Alumno
    {
       
       private string identificador;
       private string nombre;
       private string mail;
       private string ciclo;
       private int curso;
       private string foto;
       private int activo;

        public Alumno()
        {

        }

        public Alumno(string identificador, string nombre, string mail, string ciclo, int curso, string foto, int activo)
        {
            this.Identificador = identificador;
            this.Nombre = nombre;
            this.Mail = mail;
            this.Ciclo = ciclo;
            this.Curso = curso;
            this.Foto = foto;
            this.Activo = activo;
        }

        public string Identificador { get => identificador; set => identificador = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Ciclo { get => ciclo; set => ciclo = value; }
        public int Curso { get => curso; set => curso = value; }
        public string Foto { get => foto; set => foto = value; }
        public int Activo { get => activo; set => activo = value; }
    }
}
