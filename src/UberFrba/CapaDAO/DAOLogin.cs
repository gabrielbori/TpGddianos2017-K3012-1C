using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UberFrba.Model;

namespace UberFrba.CapaDAO
{
    class DAOLogin:SqlConnector
    {
        public static bool iniciarSesionConPassword(string user, int rol, string pass) 
        {
            return true;
        }

        public static bool existeUsuario(string user) 
        {
            return true;
        }
    }
}
