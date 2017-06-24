using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurante_Delicias_del_mar.modelo
{
    class usuario
    {
        private int id;
        private string nombe;
        private string apellido;
        private int rol;
        private int status;
        private string pass;
        private bool respuesta;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string Nombe
        {
            get { return nombe; }
            set { nombe = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public int Idrol
        {
            get { return rol; }
            set { rol = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }



        public bool Respuesta
        {
            get { return respuesta; }
            set { respuesta = value; }
        }
    }
}
