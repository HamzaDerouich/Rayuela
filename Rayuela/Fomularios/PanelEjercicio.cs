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
    public partial class PanelEjercicio : Form
    {
        public PanelEjercicio()
        {
            InitializeComponent();
        }

        private void tabPage8_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CRUDEJERCICIO ejercicio_final = new CRUDEJERCICIO();
            List<Alumno> alumno_list;
            int indice  = tabControl1.SelectedIndex;
            if( indice == 0)
            {
                alumno_list = ejercicio_final.Select("ASIR",1);  
                foreach( Alumno alumno in alumno_list )
                {
                    // Floulayou panel 

                    FlowLayoutPanel flowLayoutPanel = new FlowLayoutPanel();
                    flowLayoutPanel.FlowDirection = FlowDirection.LeftToRight;
                    flowLayoutPanel.BorderStyle = BorderStyle.FixedSingle;
                    flowLayoutPanel.Dock = DockStyle.Fill;

                   // Panel contenedor
                   Panel panel = new Panel();
                   panel.BackColor = Color.LightCyan;
                   panel.BorderStyle = BorderStyle.FixedSingle;
                   panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;


                  // Imagen usuario 

                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Image = Image.FromFile(alumno.Foto);
                    pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBox.Height = 50;
                    pictureBox.Width = 50;

                    // Nombre usuario 

                    Label lbl = new Label();
                    lbl.AutoSize = true;
                    lbl.Text = alumno.Nombre;
                    lbl.Dock = DockStyle.Bottom;

                   // Añadimos los datos al panel contendor 

                  panel.Controls.Add(pictureBox);
                  panel.Controls.Add(lbl);
                  
                  // Añadimos los datos al panel final 

                 flowLayoutPanel.Controls.Add(panel);

                 tabPage1.Controls.Add(flowLayoutPanel);   
               
                }
            }
        }
    }
}
