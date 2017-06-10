using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Model;
using UberFrba.CapaDAO;

namespace UberFrba.CapaDAO
{
    class DAOUsuario : SqlConnector
    {
        public static string getUsuario(int id)
        {
            DataTable table = retrieveDataTable("GET_USUARIO_POR_DNI", id);
            DataRow row = table.Rows[0];
            return row["USUA_USERNAME"] as string;
        }

        public static void cambiarPassword(String usuario,String nuevaPassword)
        {
            executeProcedure("CAMBIAR_PASSWORD",usuario,nuevaPassword); 
            
        }


    }
}
