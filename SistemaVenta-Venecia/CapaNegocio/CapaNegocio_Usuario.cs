
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CapaNegocio_Usuario
    {
        private  CapaDatos_Usuarios objCapaDatos_Usuario = new CapaDatos_Usuarios();
        public List<Usuario> Listar()
        {
            return objCapaDatos_Usuario.Listar();
        }
    }
}
