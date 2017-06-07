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
        public static DataTable getViajes(int idPersona, int mes, int año)
        {

            return retrieveDataTable("GET_VIAJES_A_FACTURAR", idPersona, mes, año);
        }

        //CREA FACTURA
        public static int crearFactura(int idPersona, DateTime fecha_inicio, DateTime fecha_final, DataGridViewRowCollection viajes, Decimal montoTotal)
        {
            return (executeProcedureWithReturnValue("CREAR_FACTURA", idPersona, DateTime.Today,
                                                        fecha_inicio, fecha_final, crearData(viajes), montoTotal));
        }

        public static int buscarIDFacturaInsertado()
        {
            return executeProcedureWithReturnValue("GET_ID_FACTURA_INSERTADO");
        }

        //FUNCIONES AUXILIARES
        private static DataTable crearData(DataGridViewRowCollection viajes)
        {
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Precio unitario");

            for (int i = 0; i < viajes.Count; i++)
            {
                var row = data.NewRow();

                row["ID"] = Convert.ToInt32(viajes[i].Cells["ID"].Value);
                row["Precio unitario"] = Convert.ToInt32(viajes[i].Cells["Precio unitario"].Value); //cambiar el convert

                data.Rows.Add(row);
            }
            return data;
        }

        public static int viajeYaFacturado(DataGridViewRowCollection viajes)
        {
            return executeProcedureWithReturnValue("VIAJE_YA_FACTURADO",crearData(viajes));
        }

    }

}
