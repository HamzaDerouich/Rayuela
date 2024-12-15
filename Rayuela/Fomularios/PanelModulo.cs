using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rayuela
{
    public partial class PanelModulo : Form
    {
        Dictionary<int, List<string>> listado_cursos;
        string nombre;
        public PanelModulo( string nombre ,Dictionary<int, List<string>> listado_cursos)
        {
            InitializeComponent();
            this.listado_cursos = listado_cursos;
            this.nombre = nombre;
            MostrarInfoCurso();
        }

        private void MostrarInfoCurso()
        {

            lblCiclo.Text = nombre;
            foreach (KeyValuePair<int, List<string>> kvp in listado_cursos)
            {
                int año = kvp.Key;
                if ( año == 1)
                {
                    foreach (string i in kvp.Value)
                    {
                        txtcurso.Items.Add(i);
                    }
                }
                else
                {
                    foreach (string i in kvp.Value)
                    {
                        txtCurso2.Items.Add(i);
                    }
                }
            }
        }
    }
}
