using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.CapaDAO
{
    class DAOFacturacion : SqlConnector
    {

        //OBTIENE EL NOMBRE DEL CLIENTE SEGUN EL DNI
        public static String getNombrePersona(int dni)
        {
            DataTable table = retrieveDataTable("GET_PERSONA_POR_DNI");
            return dataRowToNombre(table.Rows[0]);
        }

        public static string dataRowToNombre(DataRow row)
        {
            return Convert.ToString(row["PERS_NOMBRE"]);
        }


        //OBTIENE EL APELLIDO DEL CLIENTE SEGUN EL DNI
        public static String getApellidoPersona(int dni)
        {
            DataTable table = retrieveDataTable("GET_PERSONA_POR_DNI");
            return dataRowToApellido(table.Rows[0]);
        }

        public static string dataRowToApellido(DataRow row)
        {
            return Convert.ToString(row["PERS_APELLIDO"]);
        }

    }
}
