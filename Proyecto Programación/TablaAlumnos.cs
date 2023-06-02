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
    public partial class TablaAlumnos : Form
    {
        public TablaAlumnos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Registros = new Form();
        }

        private void TablaAlumnos_Load(object sender, EventArgs e)
        {
            Conexion conexionb = new Conexion();
            conexionb.Abrir();

            string cadena = "SELECT * FROM Registroalumnos";
            SqlCommand comando = new SqlCommand(cadena, conexionb.conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            tablaAlum.DataSource = tabla;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form Registros = new Form();
        }

        private void TablaAlumnos_Load_1(object sender, EventArgs e)
        {
            Conexion conexionb = new Conexion();
            conexionb.Abrir();

            string cadena = "SELECT * FROM Registroalumnos";
            SqlCommand comando = new SqlCommand(cadena, conexionb.conectarbd);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            tablaAlum.DataSource = tabla;
        }

        private void tablaAlum_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
