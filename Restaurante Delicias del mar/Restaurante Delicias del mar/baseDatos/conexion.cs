using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace sistemaRestaurante.baseDatos
{
    class conexion
    {
        private String cadenaConexionBaseDeDatos;
        public String obtenerCadenaDeConexion()
        {
            //aqui se encuentra la cadena de conexion
            cadenaConexionBaseDeDatos = "Data Source=DESKTOP-GPJ0N36;Initial Catalog=restaurante;Persist Security Info=True;User ID=VictorJ;Password=12345";
            return cadenaConexionBaseDeDatos;
        }


        ///////
        private SqlConnection conexionBaseDatos;
        public conexion()
        {
            conexionBaseDatos = new SqlConnection(obtenerCadenaDeConexion());
        }

          public SqlConnection openDataBase()
        {
            conexionBaseDatos.Open();
            if (conexionBaseDatos == null)
            {
                conexionBaseDatos.Close();
            }
            return conexionBaseDatos;
        }

        /// <summary>
        /// Metodo encargado de Cerrar la conexion si esta Abierta.
        /// </summary>
        public void closeDatabase()
        {
            try
            {
                conexionBaseDatos.Close();
            }
            catch (Exception _ex)
            {
                String mnsaje = _ex.Message;
            }
        }



    }
}
