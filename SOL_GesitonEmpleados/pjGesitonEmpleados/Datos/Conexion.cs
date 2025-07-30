using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pjGesitonEmpleados.Datos
{
    public class Conexion
    {
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private static Conexion Con = null;

        // Constructor de la clase 
        private Conexion() {
            this.Servidor = "SERVER-JAV";
            this.Base = "db_gestion_empleados";
            this.Clave = "123456";
            this.Usuario = "javier";
        }

        // Ya viene en cchart
        public SqlConnection CrearConexion() {

            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = $"Server={this.Servidor}; Database={this.Base}; User Id={this.Usuario}; Password={this.Clave}";
            }
            catch(Exception ex) {
                Cadena = null;
                throw ex;
            }

            return Cadena;
        }

        public static Conexion crearInstancia() {
            if (Con == null) {
                Con = new Conexion();
            }
            return Con;
        
        }
    }
}
