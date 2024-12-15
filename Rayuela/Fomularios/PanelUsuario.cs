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
    public partial class PanelUsuario : Form
    {
        Alumno alumno;
        HashSet<DateTime> conexiones = new HashSet<DateTime>();
        public PanelUsuario(Alumno alumno)
        {
            InitializeComponent();
            this.alumno = alumno;
            MostrarInfoUsuario();
            CargarConexion();

           
        }

        private void CargarConexion()
        {
            DateTime conexion = DateTime.Now;
            conexiones.Add(conexion);
            List<DateTime> lista = conexiones.OrderByDescending(f => f).ToList();
            lblconexion.Text = lista.Last().ToString();


        }

        public void MostrarInfoUsuario()
        {
            lblNombre.Text = alumno.Nombre;
            lblMail.Text = alumno.Mail;
            lblCurso.Text = alumno.Curso.ToString() + "ª";
            lblCiclo.Text = alumno.Ciclo;
            ImagenUsuario.Image = Image.FromFile(alumno.Foto);
        }

        private void datosPersonalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DatosPersonales datosPersonales = new DatosPersonales(alumno);
            datosPersonales.Show();
        }

        private void espacioPersonalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void misCalificacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calificaciones panel_calificaciones = new Calificaciones(alumno);
            panel_calificaciones.Show();
        }

        private void misCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           FormCursos cursos = new FormCursos(alumno);
            cursos.Show();
        }

        private void misFaltasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAsitencia asistencia = new FormAsitencia(alumno);
            asistencia.Show();
        }

        private void misModulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormModulos modulos = new FormModulos(alumno);
            modulos.Show();
        }

        private void informacionCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PanelEjercicio panelEjercicio = new PanelEjercicio();
            panelEjercicio.Show();
        }
    }
}
