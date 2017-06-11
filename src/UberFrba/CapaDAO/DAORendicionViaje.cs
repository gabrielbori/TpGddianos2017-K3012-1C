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
    class DAORendicionViaje : SqlConnector
    {
        //OBTIENE LOS TURNOS
        public static DataTable getTurnos()
        {
            return retrieveDataTable("GET_TURNOS");
        }

        //OBTIENE LOS VIAJES SEGUN CHOFER, FECHA Y TURNO
        public static DataTable getViajes(int idChofer, DateTime fecha, int idTurno, decimal porcentaje)
        {

            return retrieveDataTable("GET_VIAJES_A_PAGAR", idChofer, fecha, idTurno,porcentaje);
        }

        //CREA LA RENDICION FALTA LO DEL PORCENTAJE
        public static void crearRendicion(DateTime fecha, int chofer, int turno, decimal importeTotal, decimal porcentaje)
        {
            executeProcedure("CREAR_PAGO", fecha, chofer, turno, importeTotal,porcentaje);
        }

        public static int buscarIDPagoInsertado()
        {
            return executeProcedureWithReturnValue("GET_ID_PAGO_INSERTADO");
        }

        public static int viajeYaRendido(DataGridViewRowCollection viajes)
        {
            return executeProcedureWithReturnValue("VIAJE_YA_RENDIDO", crearData(viajes));
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
        }

    }



