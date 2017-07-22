using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sistemaRestaurante.baseDatos;
using sistemaRestaurante.modelo;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace sistemaRestaurante.controlador
{
    class controlDireccion
    {
        conexion conexion = new conexion();
        public Boolean altaDireccion(direccion _direcion)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_altaDireccion", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@numero", _direcion.Numero);
            comando.Parameters.AddWithValue("@calle", _direcion.Calle);
            comando.Parameters.AddWithValue("@colonia", _direcion.Colonia);
          


            try
            {
                insertar = comando.ExecuteNonQuery();
                if (insertar < 0)
                {
                    respuesta = true;
                }
                conexion.closeDatabase();
            }
            catch (Exception)
            {
                conexion.closeDatabase();
                throw;

            }

            return respuesta;



        }
    }
}
