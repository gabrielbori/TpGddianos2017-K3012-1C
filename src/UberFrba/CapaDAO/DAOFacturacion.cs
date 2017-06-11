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

       

        //OBTIENE VIAJES A FACTURAR
        public static DataTable getViajes(int idPersona, int mes, int año)
        {

            return retrieveDataTable("GET_VIAJES_A_FACTURAR", idPersona, mes, año);
        }

        //CREA FACTURA
        public static int crearFactura(int idPersona, DateTime fecha_inicio, DateTime fecha_final, Decimal montoTotal)
        {
            return (executeProcedureWithReturnValue("CREAR_FACTURA", idPersona, DateTime.Today,
                                                        fecha_inicio, fecha_final, montoTotal));
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
            

            for (int i = 0; i < viajes.Count; i++)
            {
                var row = data.NewRow();

                row["ID"] = Convert.ToInt32(viajes[i].Cells["ID"].Value);
                

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
