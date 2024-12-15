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
    public partial class PanelAsitencia : Form
    {
        Dictionary<string, List<DateTime>> faltas_asistencia;
        public PanelAsitencia(Dictionary<string, List<DateTime>> notas)
        {
            this.faltas_asistencia = notas;
            InitializeComponent();
            CargarInformacion();
        }

        private void CargarInformacion()
        {
            foreach (KeyValuePair<string, List<DateTime>> punto in faltas_asistencia)
            {
                lblModulo.Text = punto.Key;
                foreach (DateTime i in punto.Value)
                {
                    txtnota.Items.Add(i);
                }
            }

        }
    }
}
