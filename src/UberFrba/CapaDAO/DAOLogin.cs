using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UberFrba.Model;

namespace UberFrba.CapaDAO
{
    class DAOLogin : SqlConnector
    {

        private static String getUserID(string user)
        {
            return Globals.username;
        }

        

        public static bool existeUsuario(string user)
        {
            return executeProcedureWithReturnValue("EXISTE_USUARIO", user) != 0;
        }


        public static bool iniciarSesionConPassword(string user, int rol, string pass)
        {
            if (contraseniaCorrecta(user, pass))
            {
                //loginCorrecto(user);
                return iniciarSesion(user, rol);
                
            }
            return false;
        }

        public static bool contraseniaCorrecta(string user, string pass)
        {
           
           return executeProcedureWithReturnValue("PASSWORD_CORRECTA", user, Encriptacion.getSHA256(pass)) != 0;
        }

        private static bool iniciarSesion(string user, int rol)
        {
            List<int> funcionalidades = null;//getFuncionalidades(rol);
            

           // Globals.setUser(user, funcionalidades, rol);
            Globals.setUser(user, null, rol);

            return true;
        }

        private static List<int> getFuncionalidades(int rolID)
        {
            DataTable funcs = retrieveDataTable("Get_Funcionalidades_Por_Rol", rolID);
            List<int> funcionalidades = new List<int>();

            for (int i = 0; i < funcs.Rows.Count; i++)
            {
                funcionalidades.Add((int)funcs.Rows[i][0]);
            }
            return funcionalidades;
        }

        public static DataTable getRolesUsuario(string user)
        {
            return retrieveDataTable("GET_ROLES_USUARIO", user);
        }

    }
}
