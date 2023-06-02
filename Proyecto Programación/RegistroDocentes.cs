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

namespace Proyecto_Programación
{
    public partial class RegistroDocentes : Form
    {
        public RegistroDocentes()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RegistroDocentes_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();  
            Form Registros = new Form();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            Form form1 = new TablaDocente();
            this.Hide();
            form1.ShowDialog();
            this.Show();
        }

        private void RegistroDocentes_Load_1(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Conexion conexionb = new Conexion();
            conexionb.Abrir();

            string Nombre = Nombred.Text;
            string Apellido = Apellidod.Text;
            string DPI = Dpid.Text;
            string NIT = Nitd.Text;
            string Direccion = Direcciond.Text;
            string Correo = Correod.Text;
            string Cedula = Cedulad.Text;
            string Genero = Generod.Text;
            string Telefono = Telefonod.Text;
            string JornadaLaboral = JornadaLaborald.Text;

            string cadena = "insert into Registrodocentes(Nombre,Apellidos,DPI,NIT,Dirección,Correo,Cedula,Genero,Telefono,JornadaLaboral)values('" + Nombred.Text + "','" + Apellidod.Text + "','" + Dpid.Text + "','" + Nitd.Text + "','" + Direcciond.Text + "','" + Correod.Text + "','" + Cedulad.Text + "','" + Generod.Text + "','" + Telefonod.Text + "','" + JornadaLaborald.Text + "')";
            SqlCommand comando = new SqlCommand(cadena,conexionb.conectarbd);
            comando.ExecuteNonQuery();
            MessageBox.Show("Se ha Registrado Correctamente");

            Nombred.Text = "";
            Apellidod.Text = "";
            Dpid.Text = "";
            Nitd.Text = "";
            Direcciond.Text = "";
            Correod.Text = "";
            Cedulad.Text = "";
            Generod.Text = "";
            Telefonod.Text = "";
            JornadaLaborald.Text = "";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
