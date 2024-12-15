using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rayuela
{
    public partial class Rayuela : Form
    {
        bool correcto = false;
        bool correctopsw = false;
        public Rayuela()
        {
            InitializeComponent();
        }



        // Links 


        // Link Europa

        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.educarex.es/edutecnologias/rayuela-financiacion-feder.html") { UseShellExecute = true });

        }

        // Link Clave 
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://clave.gob.es/clave_Home/Clave-Movil/App-clave.html") { UseShellExecute = true });
        }

        // Link Acesibiladad

        private void lblAcesibilidad_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://rayuela.educarex.es/modulo_acceso/Accesibilidad.html") { UseShellExecute = true });

        }

        // Link Tesela
        private void Tesela_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://tesela.educarex.es/") { UseShellExecute = true });

        }

        // Link Youtube
        private void lblYoutube_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.youtube.com/channel/UCtoE75p5L_DLK77JLQmvHRw") { UseShellExecute = true });
        }

        // Link Twitter
        private void lblTwitter_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://x.com/noticiasrayuela") { UseShellExecute = true });
        }

        // Links Apps
        private void lblApps_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://rayuela.educarex.es/modulo_acceso/controlador.rayuela") { UseShellExecute = true });
        }

        // Link Certificado Digital

        private void CertificadoDigital_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.sede.fnmt.gob.es/certificados/persona-fisica") { UseShellExecute = true });

        }

        // Link Solicitud

        private void lblSolicitud_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://rayuela.educarex.es/secvir/jsp/seguimiento/DetAccTra.jsp") { UseShellExecute = true });
        }
        // Link Aprende
        private void lblAprende_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://rayuelaformacion.educarex.es/modulo_acceso/") { UseShellExecute = true });

        }

        // Recuperar Contraseña
        private void label2_Click(object sender, EventArgs e)
        {
            RecuperarContraseña recuperar_contraseña = new RecuperarContraseña();
            recuperar_contraseña.Show();
        }

        // Btn entrar link
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            // Instanciamos los objetos 
            CRUDALUMNOS acceso = new CRUDALUMNOS();
            List<Alumno> listadoAlumnos = acceso.Select(); // Obtenemos los datos de los alumnos


            // Declaracion de variables 
            string nombre_usuario = txtUser.Text.ToString(); // Limpiamos el nombre del textbox
            string nombre_limpio = nombre_usuario.Trim();
            bool existe = false; // Comprobamos que las credenciales son correctas
            Alumno usuario = new Alumno();
           

           
           
                foreach (Alumno alumno in listadoAlumnos)
                {
                    string[] nombre_completo = alumno.Nombre.ToString().Split(' ');
                    string nombre = nombre_completo[0];
                    if (nombre.Equals(nombre_limpio))
                    {
                        existe = true;
                        usuario = alumno; 
                    }
                }

            if(!existe.Equals(false))
            {
                Servicios servicios = new Servicios(usuario);
                servicios.Show();
            } else
            {
                MessageBox.Show("Error datos no validos!!");
                txtContraseña.Text = "";
                txtUser.Text = "";
                txtUser.Enabled = true;
                txtUser.Focus();
            }

            //txtContraseña.Enabled = false;

        }

        // Validacion usuario 
        private void txtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtUsuario = sender as TextBox;
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                lblError.Text = "Solo se admiten letras o números";
                lblError.Visible = true;
                e.Handled = true;
            }
            else
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    if (txtUsuario.Text.Length >= 10)
                    {
                        lblError.Text = "No se permiten mas de 10 caracteres y menos de 3!!";
                        lblError.Visible = true;
                        e.Handled = true;
                    }
                    else
                    {
                        lblError.Visible=false;
                        correcto = true;
                    }

                }


            }
        }

        private void txtUser_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) 
            {
                if (correcto == true)
                {
                    txtUser.Enabled = false;
                    txtContraseña.Enabled = true;
                    txtContraseña.Focus();
                    correcto = false;
                }    
            }
        }


        // Validación contraseña

        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtPasswd = sender as TextBox;
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                lblErrorPsw.Text = "Solo se admiten letras o números";
                lblErrorPsw.Visible = true;
                e.Handled = true;
            }
            else
            {
                if (char.IsControl(e.KeyChar)) 
                {
                    e.Handled = false;
                } 
                else
                {
                    if (txtPasswd.Text.Length > 10)
                    {
                        lblErrorPsw.Text = "No se permiten mas de 10 caracteres!!";
                        lblErrorPsw.Visible = true;
                        e.Handled = true;
                    }
                    else
                    {
                            lblErrorPsw.Visible = false;
                            correctopsw = true;   
                    }
                    
                }
            }
        }

        private void txtContraseña_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (correctopsw == true)
                {
                    btnEntrar.Focus();
                    btnEntrar.Enabled = true;
                    txtContraseña.Enabled = false;
                    correctopsw = false;
                }
            }
        }
    }
}
