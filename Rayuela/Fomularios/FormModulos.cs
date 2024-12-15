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
    public partial class FormModulos : Form
    {
        Alumno alumno;
        CRUDMODULOS crud_modulos = new CRUDMODULOS();
        Dictionary<string, Dictionary<int, List<string>>> listado_modulos = new Dictionary<string, Dictionary<int, List<string>>>();

        public FormModulos(Alumno alumno)
        {
            this.alumno = alumno;
            InitializeComponent();
            CargarModulos();
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


        private void CargarModulos()
        {

            List<Modulos> modulos_obtenidos = crud_modulos.Select();
            foreach (Modulos modulos in modulos_obtenidos)
            {
                if (!listado_modulos.ContainsKey(modulos.Ciclo))
                {
                    listado_modulos[modulos.Ciclo] = new Dictionary<int, List<string>>();
                }

                if (!listado_modulos[modulos.Ciclo].ContainsKey(modulos.Curso))
                {
                    listado_modulos[modulos.Ciclo][modulos.Curso] = new List<string>();
                }

                listado_modulos[modulos.Ciclo][modulos.Curso].Add(modulos.NombreCompleto);
            }

            foreach (KeyValuePair<string, Dictionary<int, List<string>>> ciclo in listado_modulos)
            {
                string clave1 = ciclo.Key;
                Button button = new Button();
                button.Text = clave1;
                button.Font = new Font("Bahnschrift", 16, FontStyle.Regular);
                button.Size = new Size(60, 50);
                button.AutoSizeMode = AutoSizeMode.GrowAndShrink;
                button.ForeColor = Color.White;
                button.Tag = ciclo.Value;
                button.Click += Button_Click; ;
                flowLayoutPanel1.Controls.Add(button);


            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
           Button button = (Button)sender;
           string nombre = button.Text;
           Dictionary<int , List<string>> modulosDelCiclo = (Dictionary<int, List<string>>)button.Tag;

            PanelModulo panelModulo = new PanelModulo(nombre ,modulosDelCiclo);
            panelModulo.Show();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}


