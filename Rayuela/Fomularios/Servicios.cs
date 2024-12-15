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
    public partial class Servicios : Form
    {
        Alumno alumno;
        public Servicios(Alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
        }

        private void Seguimiento_Click(object sender, EventArgs e)
        {
            PanelUsuario panelUsuario = new PanelUsuario(alumno);
            panelUsuario.Show();
        }

        private void Secretaria_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Todavía no disponible");
        }
    }
}
