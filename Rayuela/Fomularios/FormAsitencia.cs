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
    public partial class FormAsitencia : Form
    {
        Alumno alumno;
        Dictionary<string, List<DateTime>> diccionario_faltas = new Dictionary<string, List<DateTime>>();
        CRUDFALTASASITENCIA crud_cursos = new CRUDFALTASASITENCIA();
        List<int> cursos = new List<int>();
        string nombre = "";

        public FormAsitencia(Alumno alumno)
        {
            this.alumno = alumno;
            InitializeComponent();
            MostrarInfoUsuario();
            CargarCursos();
        }

        private void CargarCursos()
        {
            List<Faltas> listado_faltas = crud_cursos.Select();
            foreach (Faltas falta in listado_faltas)
            {
                if (!diccionario_faltas.ContainsKey(falta.Modulo))
                {
                    diccionario_faltas[falta.Modulo] = new List<DateTime>();
                }
                 diccionario_faltas[falta.Modulo].Add(falta.Fecha);
            }



            foreach (KeyValuePair<string, List<DateTime>> kvp in diccionario_faltas)
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


            Dictionary<string, List<DateTime>> faltas_asitencia = new Dictionary<string, List<DateTime>>();
            faltas_asitencia[ciclo] = diccionario_faltas[ciclo];

           PanelAsitencia panelAsitencia = new PanelAsitencia(faltas_asitencia);
           panelAsitencia.Show();
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
