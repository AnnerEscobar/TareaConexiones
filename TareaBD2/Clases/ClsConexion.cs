using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace TareaBD2.Clases
{
    class ClsConexion
    {
        public SqlConnection conexion;
        private String _conexion { get; }

        public  ClsConexion()
        {

            _conexion = "Data Source=LT-RULDIN\\SQLEXPRESS2014;Initial Catalog=programacion1;Integrated Security=True";

        }

        /// <summary>
        /// Cierra la conexion.
        /// </summary>
        public void cerrarConexionBD()
        {
            conexion.Close();
        }



        /// <summary>
        /// abre la conexion
        /// </summary>
        public void abrirConexion()
        {
            conexion = new SqlConnection(_conexion);
            conexion.Open();
        }

    }    
}
