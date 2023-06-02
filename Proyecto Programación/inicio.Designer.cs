namespace Proyecto_Programación
{
    partial class inicio
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            panel2 = new Panel();
            btnAcceder = new Button();
            btnCerrar = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox1.Image = Properties.Resources.logo_u_removebg_preview;
            pictureBox1.Location = new Point(30, 112);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(175, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Imprint MT Shadow", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(367, 41);
            label2.Name = "label2";
            label2.Size = new Size(232, 38);
            label2.TabIndex = 2;
            label2.Text = "Inicio de Sesión";
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.None;
            textBox1.BackColor = Color.FromArgb(128, 64, 64);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.Window;
            textBox1.ImeMode = ImeMode.NoControl;
            textBox1.Location = new Point(354, 112);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 24);
            textBox1.TabIndex = 3;
            textBox1.Text = "Usuario";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 224, 224);
            panel1.Enabled = false;
            panel1.Location = new Point(354, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(289, 3);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.None;
            textBox2.BackColor = Color.FromArgb(128, 64, 64);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.Window;
            textBox2.ImeMode = ImeMode.NoControl;
            textBox2.Location = new Point(354, 193);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 24);
            textBox2.TabIndex = 5;
            textBox2.Text = "Contraseña";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Enabled = false;
            panel2.Location = new Point(354, 214);
            panel2.Name = "panel2";
            panel2.Size = new Size(289, 3);
            panel2.TabIndex = 5;
            // 
            // btnAcceder
            // 
            btnAcceder.BackColor = Color.FromArgb(128, 64, 64);
            btnAcceder.Font = new Font("Sylfaen", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAcceder.ForeColor = SystemColors.ControlLightLight;
            btnAcceder.Location = new Point(401, 284);
            btnAcceder.Name = "btnAcceder";
            btnAcceder.Size = new Size(163, 45);
            btnAcceder.TabIndex = 6;
            btnAcceder.Text = "Acceder";
            btnAcceder.UseVisualStyleBackColor = false;
            btnAcceder.Click += btnAcceder_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.FromArgb(128, 64, 64);
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.ForeColor = Color.LightCoral;
            btnCerrar.Location = new Point(453, 344);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(65, 26);
            btnCerrar.TabIndex = 7;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(64, 0, 0);
            pictureBox2.Location = new Point(-2, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(232, 397);
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(733, 398);
            Controls.Add(btnCerrar);
            Controls.Add(btnAcceder);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label2;
        private TextBox textBox1;
        private Panel panel1;
        private TextBox textBox2;
        private Panel panel2;
        private Button btnAcceder;
        private Button btnCerrar;
        private PictureBox pictureBox2;
    }
}