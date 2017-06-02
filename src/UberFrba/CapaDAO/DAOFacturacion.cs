using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UberFrba.Model;

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

        //OBTIENE VIAJES A FACTURAR
        public static DataTable getViajes (int idPersona, int mes, int año)
        {

            return retrieveDataTable("GET_VIAJES_A_FACTURAR", idPersona, mes, año);
        }

        //CREA FACTURA
        public static long crearFactura(int idPersona, DateTime fecha, DataGridViewRowCollection viajes, Decimal montoTotal)
        {
            return executeProcedureWithLongReturnValue("CREAR_FACTURA", idPersona, Globals.getDateFechaSistema(), fecha, crearData(viajes), montoTotal);
        }

                //FUNCIONES AUXILIARES
        private static DataTable crearData(DataGridViewRowCollection integers)
        {
            List<int> ints = new List<int>();

            for (int i = 0; i < integers.Count; i++)
            {
                ints.Add((int)integers[i].Cells["ID"].Value); //es el id del viaje
                ints.Add((int)integers[i].Cells["Precio Unitario"].Value);
            }

            return Globals.intsToDataTable(ints);
        }
    }
    
}
