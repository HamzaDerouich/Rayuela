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
    public partial class PanelNota : Form
    {
        Dictionary<string, List<int>> notas;
        public PanelNota(Dictionary<string, List<int>> notas)
        {
            this.notas = notas;
            InitializeComponent();
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            foreach(KeyValuePair<string , List<int>> punto in notas)
            {
                lblModulo.Text = punto.Key;
                foreach( int i in punto.Value )
                {
                    txtnota.Items.Add( i ); 
                }
            }
            
        }
    }
}
