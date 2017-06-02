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

        //OBTIENE ID DE LA PERSONA SEGUN EL DNI Y EL TELEFONO
        public static int getIDPersona(int dni, int telefono)
        {
            DataTable table = retrieveDataTable("GET_PERSONA_POR_DNI_TELEFONO", dni, telefono);
            return dataRowToID(table.Rows[0]);
        }

        public static int dataRowToID(DataRow row)
        {
            return Convert.ToInt32(row["PERS_ID"]);
        }


        //OBTIENE EL NOMBRE DEL CLIENTE SEGUN EL DNI Y EL TELEFONO
        public static String getNombrePersona(int dni, int telefono)
        {
            DataTable table = retrieveDataTable("GET_PERSONA_POR_DNI_TELEFONO", dni, telefono);
            return dataRowToNombre(table.Rows[0]);
        }

        public static string dataRowToNombre(DataRow row)
        {
            return Convert.ToString(row["PERS_NOMBRE"]);
        }


        //OBTIENE EL APELLIDO DEL CLIENTE SEGUN EL DNIY EL TELEFONO
        public static String getApellidoPersona(int dni, int telefono)
        {
            DataTable table = retrieveDataTable("GET_PERSONA_POR_DNI_TELEFONO", dni, telefono);
            return dataRowToApellido(table.Rows[0]);
        }

        public static string dataRowToApellido(DataRow row)
        {
            return Convert.ToString(row["PERS_APELLIDO"]);
        }

        public static DataTable getViajes (int idPersona, int mes, int año){

            return retrieveDataTable("GET_VIAJES_A_FACTURAR", idPersona, mes, año);
        }
    }
}
