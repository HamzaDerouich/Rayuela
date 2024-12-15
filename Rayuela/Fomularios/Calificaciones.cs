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
    public partial class Calificaciones : Form
    {
        Alumno alumno;
        CRUDCALIFICACIONES crud_calificaciones = new CRUDCALIFICACIONES();
        Dictionary<string, List<int>> notas = new Dictionary<string, List<int>>();

        public Calificaciones(Alumno alumno)
        {
            this.alumno = alumno;
            InitializeComponent();
            CargarCalificaciones();
            MostrarInfoUsuario();
        }

        public void MostrarInfoUsuario()
        {
            lblNombre.Text = alumno.Nombre;
            lblMail.Text = alumno.Mail;
            lblCurso.Text = alumno.Curso.ToString() + "ª";
            lblCiclo.Text = alumno.Ciclo;
            ImagenUsuario.Image = Image.FromFile(alumno.Foto);
        }


        private void CargarCalificaciones()
        {
            List<Calificacion> listado_calificaciones = crud_calificaciones.Select(alumno.Identificador);
            List<Calificacion> listado_calificaciones2 = new List<Calificacion>();
            foreach( Calificacion calificacion1 in listado_calificaciones )
            {
                if( !notas.ContainsKey(calificacion1.Modulo) )
                {
                    notas[calificacion1.Modulo] = new List<int>();
                }

                notas[calificacion1.Modulo].Add(calificacion1.Puntos);
            }


            foreach (KeyValuePair<string, List<int>> kvp in notas)
            {
                Button button = new Button();
                button.Text = kvp.Key;
                button.Font = new Font("Bahnschrift", 16, FontStyle.Regular);
                button.Size = new Size(60, 50);
                button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                button.ForeColor = Color.White;
                button.Tag = kvp.Key;

                button.Click += Button_Click;
                flowLayoutPanel1.Controls.Add(button);
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string modulo = (string)btn.Tag;
            Dictionary<string, List<int>> calificacionesModulo = new Dictionary<string, List<int>>();
            calificacionesModulo[modulo] = notas[modulo];

            PanelNota panelNota = new PanelNota(calificacionesModulo);
            panelNota.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
