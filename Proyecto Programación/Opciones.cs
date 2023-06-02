using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Programación
{
    public partial class Opciones : Form
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Registros = new Form();
        }

        private void btnRegistroAlumno_Click(object sender, EventArgs e)
        {
            Form form1 = new RegistroAlumnos();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void btnRegistroDocentes_Click(object sender, EventArgs e)
        {
            Form form1 = new RegistroDocentes();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void btnRegistroAlumno_Click_1(object sender, EventArgs e)
        {
            Form form1 = new RegistroAlumnos();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void btnRegistroDocentes_Click_1(object sender, EventArgs e)
        {
            Form form1 = new RegistroDocentes();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form Registros = new Form();
        }
    }
}
