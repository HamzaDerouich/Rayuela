namespace Rayuela
{
    partial class PanelModulo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtcurso = new System.Windows.Forms.ComboBox();
            this.lblaño2 = new System.Windows.Forms.Label();
            this.txtCurso2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCiclo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 43);
            this.panel1.TabIndex = 1;
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.lblCiclo.Location = new System.Drawing.Point(13, 9);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(52, 19);
            this.lblCiclo.TabIndex = 0;
            this.lblCiclo.Text = "Curso";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(102)))), ((int)(((byte)(137)))));
            this.groupBox1.Controls.Add(this.lblaño2);
            this.groupBox1.Controls.Add(this.txtCurso2);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.lblAño);
            this.groupBox1.Controls.Add(this.txtcurso);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 158);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(14, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(195, 1);
            this.panel2.TabIndex = 40;
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.ForeColor = System.Drawing.Color.White;
            this.lblAño.Location = new System.Drawing.Point(14, 16);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(115, 19);
            this.lblAño.TabIndex = 41;
            this.lblAño.Text = "Asignaturas 1ª ";
            // 
            // txtcurso
            // 
            this.txtcurso.FormattingEnabled = true;
            this.txtcurso.Location = new System.Drawing.Point(12, 44);
            this.txtcurso.Name = "txtcurso";
            this.txtcurso.Size = new System.Drawing.Size(325, 21);
            this.txtcurso.TabIndex = 40;
            // 
            // lblaño2
            // 
            this.lblaño2.AutoSize = true;
            this.lblaño2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblaño2.ForeColor = System.Drawing.Color.White;
            this.lblaño2.Location = new System.Drawing.Point(14, 89);
            this.lblaño2.Name = "lblaño2";
            this.lblaño2.Size = new System.Drawing.Size(114, 19);
            this.lblaño2.TabIndex = 43;
            this.lblaño2.Text = "Asignaturas 2ª";
            // 
            // txtCurso2
            // 
            this.txtCurso2.FormattingEnabled = true;
            this.txtCurso2.Location = new System.Drawing.Point(12, 116);
            this.txtCurso2.Name = "txtCurso2";
            this.txtCurso2.Size = new System.Drawing.Size(325, 21);
            this.txtCurso2.TabIndex = 42;
            // 
            // PanelModulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 201);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "PanelModulo";
            this.Text = "PanelModulo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCiclo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.ComboBox txtcurso;
        private System.Windows.Forms.Label lblaño2;
        private System.Windows.Forms.ComboBox txtCurso2;
    }
}