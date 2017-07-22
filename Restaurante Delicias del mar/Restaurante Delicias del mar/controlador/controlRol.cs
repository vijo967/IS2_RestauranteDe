using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using sistemaRestaurante.baseDatos;
using sistemaRestaurante.modelo;
namespace sistemaRestaurante.controlador
{
    class controlRol
    {
        conexion conexion = new conexion();
        public List<roles> seleccionarCatProducto()
        {
            List<roles> listaRol = new List<roles>();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectRol";
            roles _roll = new roles();
          _roll.Roluser = "Seleccione";

            listaRol.Add(_roll);

            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    roles _rol = new roles();
                    _rol.Id = int.Parse(lector[0].ToString());
                  _rol.Roluser = lector[1].ToString();
                    listaRol.Add(_rol);
                }
            }
            catch (Exception ex)
            {
                string m = ex.Message;
                Comando.Dispose();
            }

            finally
            {
                conexion.closeDatabase();
            }

            return listaRol;
        }
    }
}
