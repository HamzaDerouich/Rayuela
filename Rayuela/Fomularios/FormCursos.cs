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
    public partial class FormCursos : Form
    {
        Alumno alumno;
        Dictionary<string, List<int>> listado_cursos = new Dictionary<string, List<int>>();
        CRUDCURSOS crud_cursos = new CRUDCURSOS();  
        List<int> cursos = new List<int>();
        string nombre = "";

        public FormCursos(Alumno alumno)
        {
            this.alumno = alumno;
            InitializeComponent();
            MostrarInfoUsuario();
            CargarCursos();
        }

        private void CargarCursos()
        {
            List<Cursos> cursos = crud_cursos.Select();
            foreach (Cursos curso in cursos)
            {
                if (!listado_cursos.ContainsKey(curso.Ciclo))
                {
                    listado_cursos[curso.Ciclo] = new List<int>();
                }
                listado_cursos[curso.Ciclo].Add(curso.Curso);
            }



            foreach (KeyValuePair<string, List<int>> kvp in listado_cursos)
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
            string ciclo = (string)btn.Tag; 

           
            Dictionary<string, List<int>> cursosCiclo = new Dictionary<string, List<int>>();
            cursosCiclo[ciclo] = listado_cursos[ciclo];

            PanelCurso panel = new PanelCurso(cursosCiclo);
            panel.Show();
        }

        public void MostrarInfoUsuario()
        {
            lblNombre.Text = alumno.Nombre;
            lblMail.Text = alumno.Mail;
            lblCurso.Text = alumno.Curso.ToString() + "ª";
            lblCiclo.Text = alumno.Ciclo;
            ImagenUsuario.Image = Image.FromFile(alumno.Foto);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
