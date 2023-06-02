using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Proyecto_Programación;
using System.Data.Sql;

namespace Proyecto_Programación
{
    internal class Conexion
    {
        string cadena = "Data Source=DESKTOP-J1L81GP;Initial Catalog = Proyecto; Integrated Security = True";
        public SqlConnection conectarbd = new SqlConnection();
        
        public Conexion()
        {
            conectarbd.ConnectionString = cadena;
        }
        public void Abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion Exitosa");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir la BASE DE DATOS" + ex.Message);
            }
        }
        public void cerrar()
        {
            conectarbd.Close();
        }
    }
}
