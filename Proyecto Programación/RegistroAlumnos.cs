using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace Proyecto_Programación
{
    public partial class RegistroAlumnos : Form
    {
        public RegistroAlumnos()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();  // Ocultamos el Formulario Actual
            Form Registros = new Form();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form1 = new TablaAlumnos();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void RegistroAlumnos_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Conexion conexionb = new Conexion();
            conexionb.Abrir();

            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string DPI = txtDpi.Text;
            string Genero = txtGenero.Text;
            string FechadeNacimiento = txtFechadeNacimiento.Text;
            string Direccion = txtDireccion.Text;
            string Carnet = txtCarnet.Text;
            string Carrera = txtCarrera.Text;
            string Email = txtEmail.Text;

            string cadena = "insert into Registroalumnos(Nombre,Apellido,DPI,Genero,FechadeNacimiento,Direccion,Carnet,Carrera,Email) values('" + txtNombre.Text + "','" + txtApellido.Text + "','" + txtDpi.Text + "','" + txtGenero.Text + "','" + txtFechadeNacimiento.Text + "','" + txtDireccion.Text + "','" + txtCarnet.Text + "','" + txtCarrera.Text + "','" + txtEmail.Text + "' )";
            SqlCommand comando = new SqlCommand(cadena,conexionb.conectarbd);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se ha Registrado Correctamente");

            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDpi.Text = "";
            txtGenero.Text = "";
            txtFechadeNacimiento.Text = "";
            txtDireccion.Text = "";
            txtCarnet.Text = "";
            txtCarrera.Text = "";
            txtEmail.Text = "";





        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
