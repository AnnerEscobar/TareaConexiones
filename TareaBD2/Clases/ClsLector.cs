using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;

namespace TareaBD2.Clases
{
    class ClsLector
    {

        //public void Lector()
        //{
        //    using (SqlConnection conn = new SqlConnection(@"PAT DE LA CONEXION"))
        //    {

        //        conn.Open();
        //        using (StreamReader Reader = new StreamReader(@"C: \Users\anner\Desktop\Universidad Mariano Galvez\Tercer Semestre\Programacion 1\datosTexto.csv"))
        //        {
        //            while (!Reader.EndOfStream)
        //            {
        //                var line = Reader.ReadLine();
        //                var values = line.Split(';');
        //                var sql = "INSERT INTO PENDIENTE VALUES (" + values[0] + ", " + values[1] + ", " + values[2] + ", " + values[3] + ", " + values[4] + " )";

        //                var cmd = new SqlCommand();
        //                cmd.CommandText = sql;
        //                cmd.CommandType = System.Data.CommandType.Text;
        //                cmd.Connection = conn;
        //                cmd.ExecuteNonQuery();

        //            }
        //        }
        //        conn.Close();
            }
        }


    }
}
