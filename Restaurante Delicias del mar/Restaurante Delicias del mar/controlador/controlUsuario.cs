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
    class controlUsuario
    {
        conexion conexion = new conexion();
        public string inicioSesion(usuario _user)
        {
            string usuario = "null";

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_sesion";
            Comando.Parameters.AddWithValue("@user", _user.Nombe);
            Comando.Parameters.AddWithValue("@pass", _user.Pass);



            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    usuario _admi = new usuario();
                    usuario = lector[0].ToString();
                    _admi.Pass = lector[1].ToString();
                   // MessageBox.Show(lector[0].ToString());
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

            return usuario;
        }

        public Boolean altaUsuario(usuario _usuario)
        {

            int insertar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_altaUser", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre", _usuario.Nombe);
            comando.Parameters.AddWithValue("@apellido", _usuario.Apellido);
            comando.Parameters.AddWithValue("@idRol", _usuario.Idrol);
            comando.Parameters.AddWithValue("@pass", _usuario.Pass);
           

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


        public Boolean eliminarUsuario(usuario _usaer)
        {

            int elininar = 0;
            bool respuesta = false;
            SqlCommand comando = new SqlCommand("sp_eliminarUsuario", conexion.openDataBase());
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombreUsario", _usaer.Nombe);


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


        public List<usuario> seleccionarUsuarios()
        {
            List<usuario> listPersonal = new List<usuario>();

            SqlCommand Comando = new SqlCommand();
            Comando.Connection = conexion.openDataBase();

            Comando.CommandType = CommandType.StoredProcedure;

            Comando.CommandText = "sp_selectPersonal";
            usuario _personal = new usuario();
            _personal.Nombe= "Encargado";

            listPersonal.Add(_personal);

            try
            {
                IDataReader lector = Comando.ExecuteReader();
                while (lector.Read())
                {
                    usuario _personl = new usuario();
                    _personl.Id = int.Parse(lector[0].ToString());
                    _personl.Nombe =lector[1].ToString();
                    listPersonal.Add(_personl);
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

            return listPersonal;
        }

    }
}
