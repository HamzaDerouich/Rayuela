using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rayuela
{
    public partial class PanelCurso : Form
    {
        Dictionary<string, List<int>> listado_cursos;
        public PanelCurso(Dictionary<string, List<int>> a)
        {
            listado_cursos = a;
            InitializeComponent();
            MostrarInfoCurso();
        }

        private void MostrarInfoCurso()
        {
            foreach (KeyValuePair<string, List<int>> kvp in listado_cursos)
            {

               lblCiclo.Text = kvp.Key;
               foreach( int i in kvp.Value )
               {
                    txtcurso.Items.Add(i);
               }
               

            }
        }
    }
}
