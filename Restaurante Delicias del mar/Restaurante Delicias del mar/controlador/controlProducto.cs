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
    class controlProducto
    {

        conexion conexion = new conexion();
        public DataSet SelectProductoByCattegoria(CatProducto _catPr)
        {
            DataSet productDataSet = new DataSet();




            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();



            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectAllProducts";
            Comando.Parameters.AddWithValue("@idCategoria", _catPr.Id);
            try
            {

                SqlDataAdapter myAdapter = new SqlDataAdapter(Comando);
                productDataSet = new DataSet();
                myAdapter.Fill(productDataSet);

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

            return productDataSet;
        }


        public List<productos> seleccionarProductoComb()
        {
            List<productos> listaCtProducto = new List<productos>();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectProductosCombo";
            productos _catP = new productos();
            _catP.NombreProducto = "Seleccione";

              listaCtProducto.Add(_catP);

            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    productos _catProduto = new productos();
                    _catProduto.Id = int.Parse(lector[0].ToString());
                    _catProduto.NombreProducto = lector[1].ToString();
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



        public Boolean altaDetalleProductoIngredientes(productos _producto,ingredientes _ingrediente)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_insertarRelacionProductosEingredinentes", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto", _producto.Id);
            comando.Parameters.AddWithValue("@idIngrediente", _ingrediente.Id);





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


        public Boolean altaProducto(productos _producto,CatProducto _CatProduc)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_altaProducto", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", _producto.NombreProducto);
            comando.Parameters.AddWithValue("@Desc",_producto.Descripcion);
            comando.Parameters.AddWithValue("@Precio", _producto.Precio);
            comando.Parameters.AddWithValue("@idCat",_CatProduc.Id);


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




        public Boolean eliminarProducto(productos _producto)
        {

            int elininar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_deleteProducto", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@idProducto", _producto.Id);


            try
            {
                elininar = comando.ExecuteNonQuery();
                if (elininar < 0)
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
