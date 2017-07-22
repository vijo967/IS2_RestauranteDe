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
    class controllercatCliente
    {
        conexion conexion = new conexion();
        public List<catCliente> seleccionarCatCliente()
        {
            List<catCliente> listacatCliente = new List<catCliente>();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectCatCliente";
            catCliente _catClient = new catCliente();
            _catClient.CatUser = "Seleccione";

            listacatCliente.Add(_catClient);

            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    catCliente _catCli = new catCliente();
                    _catCli.Id = int.Parse(lector[0].ToString());
                    _catCli.CatUser = lector[1].ToString();
                    listacatCliente.Add(_catCli);
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

            return listacatCliente;
        }
    }
}
