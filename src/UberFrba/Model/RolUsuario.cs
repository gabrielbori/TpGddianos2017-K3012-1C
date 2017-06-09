using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Model
{
    class RolUsuario
    {

        public string Usuario { get; set; }
        public int RolId { get; set; }

        public RolUsuario (string usuario, int rolId)
        {
            Usuario = usuario;
            RolId = rolId;
        }
    }
}
