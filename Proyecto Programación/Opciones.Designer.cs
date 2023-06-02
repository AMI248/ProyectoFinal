namespace Proyecto_Programación
{
    partial class Opciones
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
            this.btnRegistroAlumno = new System.Windows.Forms.Button();
            this.btnRegistroDocentes = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRegistroAlumno
            // 
            this.btnRegistroAlumno.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistroAlumno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistroAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistroAlumno.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnRegistroAlumno.ForeColor = System.Drawing.Color.Snow;
            this.btnRegistroAlumno.Location = new System.Drawing.Point(80, 320);
            this.btnRegistroAlumno.Name = "btnRegistroAlumno";
            this.btnRegistroAlumno.Size = new System.Drawing.Size(112, 46);
            this.btnRegistroAlumno.TabIndex = 0;
            this.btnRegistroAlumno.Text = "Registro de Alumnos";
            this.btnRegistroAlumno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistroAlumno.UseVisualStyleBackColor = false;
            this.btnRegistroAlumno.Click += new System.EventHandler(this.btnRegistroAlumno_Click_1);
            // 
            // btnRegistroDocentes
            // 
            this.btnRegistroDocentes.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistroDocentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistroDocentes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistroDocentes.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnRegistroDocentes.ForeColor = System.Drawing.Color.Snow;
            this.btnRegistroDocentes.Location = new System.Drawing.Point(218, 320);
            this.btnRegistroDocentes.Name = "btnRegistroDocentes";
            this.btnRegistroDocentes.Size = new System.Drawing.Size(112, 46);
            this.btnRegistroDocentes.TabIndex = 1;
            this.btnRegistroDocentes.Text = "Registro de Docentes";
            this.btnRegistroDocentes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistroDocentes.UseVisualStyleBackColor = false;
            this.btnRegistroDocentes.Click += new System.EventHandler(this.btnRegistroDocentes_Click_1);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegresar.Font = new System.Drawing.Font("Sylfaen", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.btnRegresar.ForeColor = System.Drawing.Color.Snow;
            this.btnRegresar.Location = new System.Drawing.Point(153, 379);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 46);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // Opciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Programación.Properties.Resources.fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(775, 441);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnRegistroDocentes);
            this.Controls.Add(this.btnRegistroAlumno);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "Opciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Opciones";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnRegistroAlumno;
        private Button btnRegistroDocentes;
        private Button btnRegresar;
    }
}