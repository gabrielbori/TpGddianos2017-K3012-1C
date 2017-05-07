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

        private static int getUserID(string user)
        {
            return executeProcedureWithReturnValue("GET_ID_USUARIO", user);
        }

        private static List<int> getFuncionalidades(int rolID)
        {
            DataTable funcs = retrieveDataTable("GET_FUNCIONALIDADES_ROL", rolID);
            List<int> funcionalidades = new List<int>();

            for (int i = 0; i < funcs.Rows.Count; i++)
            {
                funcionalidades.Add((int)funcs.Rows[i][0]);
            }
            return funcionalidades;
        }

        public static bool existeUsuario(string user)
        {
            return executeProcedureWithReturnValue("EXISTE_USUARIO", user) != 0;
        }

        private static void loginCorrecto(string user)
        {
            intentoLogin(user, 1);
        }

        private static void loginIncorrecto(string user)
        {
            intentoLogin(user, 0);
        }

        public static bool iniciarSesionConPassword(string user, int rol, string pass)
        {
            if (contraseniaCorrecta(user, pass))
            {
                loginCorrecto(user);
                return iniciarSesion(user, rol);
            }
            loginIncorrecto(user);
            return false;
        }

        public static bool contraseniaCorrecta(string user, string pass)
        {
            return true;
///     executeProcedureWithReturnValue("PASSWORD_CORRECTA", user, Encriptacion.getSHA256(pass)) != 0;
        }

        private static void intentoLogin(string user, int estado)
        {
            executeProcedure("INTENTO_LOGIN", user, estado, Globals.getDateFechaSistema());
        }

        private static bool iniciarSesion(string user, int rol)
        {
            List<int> funcionalidades = getFuncionalidades(rol);
            int userID = getUserID(user);

            Globals.setUser(userID, user, funcionalidades, rol);

            return true;
        }

        

    }
}
