using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rayuela
{
    public partial class DatosPersonales : Form
    {
        private Alumno alumno;
        bool corrcto = false;
        string ruta_foto = " ";
        public DatosPersonales(Alumno alumno)
        {
            this.alumno = alumno;
            InitializeComponent();
            CargarInfoAlumno(alumno);
        }

        private void CargarInfoAlumno(Alumno alumno)
        {
           pictureBox2.Image = Image.FromFile(alumno.Foto);
           lblNombre.Text = alumno.Nombre;
           lblMail.Text = alumno.Mail; 
           lblCurso.Text = alumno.Curso.ToString();
           lblCiclo.Text = alumno.Ciclo.ToString(); 

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        // Btn cambiar
        private void btnCambiar_Click(object sender, EventArgs e)
        {

            if( txtMail.Text.Length == 0 || txtNombre.Text.Length == 0 || txtCiclo.Text.Length == 0 || txtCurso.Text.Length == 0 || ruta_foto == " " )
            {
                MessageBox.Show("Error campos vacios!!");
                  
            }
            else
            {
                string nombre = txtNombre.Text.ToString();
                string mail = txtMail.Text.ToString();
                string ciclo = txtCiclo.Text.ToString();
                int curso = Convert.ToInt16(txtCurso.Text.ToString());
                

                CRUDALUMNOS crud_alumnos = new CRUDALUMNOS();
                Alumno alumono_acutalizado = new Alumno();
                alumono_acutalizado.Identificador = alumno.Identificador;
                alumono_acutalizado.Nombre = nombre;
                alumono_acutalizado.Mail = mail;
                alumono_acutalizado.Ciclo = ciclo;
                alumono_acutalizado.Curso = curso;
                alumono_acutalizado.Foto = ruta_foto;

                int filas = crud_alumnos.Update(alumono_acutalizado);

                if (filas > 0)
                {
                    MessageBox.Show("Usuario actualizado correctamente");
                    Reset();
                    CargarInfoAlumno(alumono_acutalizado);
                    PanelUsuario panelUsuario = new PanelUsuario(alumono_acutalizado);
                    panelUsuario.Close();
                }
                else
                {
                    MessageBox.Show("El usuario no se ha actualizado correctamente");
                }
            } 

        }

        // Cerrrar Aplicacion
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtNombre.Text = "";
            txtMail.Text = "";
            txtCiclo.Text = "";
            txtCurso.Text = "";
            fotoUsuario.Image = null;

            txtNombre.Enabled = true;
            txtMail.Enabled = true;
            txtCiclo.Enabled = true;
            txtCurso.Enabled = true;
            fotoUsuario.Enabled = true;
        }

        // Datos personales 

        // Validacion del nombre

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if( !char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char) Keys.Space)
            {
                MessageBox.Show("Solo se admiten letras y números");
                e.Handled = true;
            }
            else
            {
                if( char.IsControl(e.KeyChar) )
                {
                    e.Handled=false;
                }
                else
                {
                    if( txtBox.Text.Length > 30 )
                    {
                        MessageBox.Show("Solo se admiten 30 caracteres!!");
                        e.Handled = true;
                    }
                }
            }

        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
           
            if( e.KeyCode == Keys.Enter )
            {
                txtMail.Focus();
                txtNombre.Enabled = false;
            }
        }

        // Validacion del correo 

        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '@' && e.KeyChar != '.' )
            {
                MessageBox.Show("Solo se admiten letras y números");
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
                    if ( txtBox.Text.Length > 50)
                    {
                        MessageBox.Show("Datos no validos mail incorrecto!!");
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtMail_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (e.KeyCode == Keys.Enter)
            {
                if( textBox.Text.Contains('@') && textBox.Text.Contains('.') )
                {
                  textBox.Enabled = false ;
                  txtCurso.Focus();
                }
                else
                {
                    MessageBox.Show("Datos no validos, vuelva a digitarlos!!");
                    txtMail.Text = "";
                }
                
             
            }
        }

        // Validacion del curso 
        private void txtCurso_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se admiten números");
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
                    if (txtBox.Text.Length > 1)
                    {
                        MessageBox.Show("Solo se admiten 1 caracter!!");
                        txtBox.Text =" ";
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtCurso_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;    
            if (e.KeyCode == Keys.Enter)
            {
                if( textBox.Text.Trim().Length == 1 )
                {
                    
                     txtCiclo.Focus();
                }
                else
                {
                    MessageBox.Show("Solo se admiten 1 caracter!!");

                    textBox.Text = "";

                }
            }
        }


        // Validacion del ciclo

        private void txtCiclo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txtBox = sender as TextBox;
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("Solo se admiten letras");
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
                    if (txtBox.Text.Length > 3)
                    {
                        MessageBox.Show("Solo se admiten 3 caracteres!!");
                        txtBox.Text = "";
                        e.Handled = true;
                    }
                }
            }
        }

        private void txtCiclo_KeyUp(object sender, KeyEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (e.KeyCode == Keys.Enter)
            {
               if( textBox.Text.Trim().Length == 0 )
                {
                    MessageBox.Show("Ciclo no valido, digite campos");
                }
               else
                {
                    fotoUsuario.Focus();
                    textBox.Enabled = false;
                }

            }
        }

        // Btn salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fotoUsuario_Click(object sender, EventArgs e)
        {
            ImagenUsuario.Filter = "Fotos JPG Y PNG |*.jpg;*.png";
            if (ImagenUsuario.ShowDialog() == DialogResult.OK) 
            {
                ruta_foto = ImagenUsuario.FileName;
                fotoUsuario.Image = Image.FromFile(ruta_foto);
                string[] datos = ruta_foto.Split('\\');
                ruta_foto = datos[7]+"\\"+datos[8];
                MessageBox.Show(ruta_foto);
             
             
            }
        }
    }
}
