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
    class ControlCatProducto
    {


        conexion conexion = new conexion();
        public List<CatProducto> seleccionarCatProducto()
        {
            List<CatProducto> listaCtProducto = new List<CatProducto>();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selecCatProdut";
           // CatProducto _catP = new CatProducto();
           // _catP.Categoria = "Seleccione";

         //   listaCtProducto.Add(_catP);

            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    CatProducto _catProduto = new CatProducto();
                    _catProduto.Id = int.Parse(lector[0].ToString());
                    _catProduto.Categoria = lector[1].ToString();
                    listaCtProducto.Add(_catProduto);
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

            return listaCtProducto;
        }
    }
}
