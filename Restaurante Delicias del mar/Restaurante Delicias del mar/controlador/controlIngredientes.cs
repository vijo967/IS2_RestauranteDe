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
    class controlIngredientes
    {
        conexion conexion = new conexion();
        public DataSet SelectAllIngredientes()
        {
            DataSet productDataSet = new DataSet();




            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();



            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectAllIngrediente";
           
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



      
        public Boolean altaIngrediente(ingredientes _ingrediente)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_insertarIngrediente", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", _ingrediente.Ingrediente);
            comando.Parameters.AddWithValue("@stock", _ingrediente.Stock);
   
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



        public Boolean eliminarIngrediente(ingredientes _ingrediente)
        {

            int elininar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_elininarIngrediente", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", _ingrediente.Ingrediente);


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




        public DataSet SelectIngredintesDeProducto(ingredientes _ingrediente)
        {
            DataSet productDataSet = new DataSet();




            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();



            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_DetalleIngredienteProducto";
            Comando.Parameters.AddWithValue("@idProducto", _ingrediente.Id);
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




    }
}
