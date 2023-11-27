using CapaDatos;
using CapaEntidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_Permiso
    {
        private CD_PERMISO objPermiso = new CD_PERMISO();
        public List<Permiso> Listar(int IdUsiaro)
        {
            return objPermiso.Listar(IdUsiaro);
        }

    }
}
