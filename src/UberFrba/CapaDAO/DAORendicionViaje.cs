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
        public static DataTable getViajes(int idChofer, DateTime fecha, int idTurno)
        {

            return retrieveDataTable("GET_VIAJES_A_PAGAR", idChofer, fecha, idTurno);
        }

        //CREA LA RENDICION FALTA LO DEL PORCENTAJE
        public static void crearRendicion(DateTime fecha, int chofer, int turno, decimal importeTotal, DataGridViewRowCollection viajes)
        {
            executeProcedure("CREAR_PAGO", fecha, chofer, turno, importeTotal, crearData(viajes));
        }

        //FUNCIONES AUXILIARES       
         private static DataTable crearData(DataGridViewRowCollection viajes)
        {
            //List<int> ints = new List<int>();
            DataTable data = new DataTable();
            data.Columns.Add("ID");
            data.Columns.Add("Precio unitario");

            for (int i = 0; i < viajes.Count; i++)
            {
                var row = data.NewRow();

                row["ID"] = Convert.ToInt32(viajes[i].Cells["ID"].Value);
                row["Precio unitario"] = Convert.ToInt32(viajes[i].Cells["Precio unitario"].Value); //ESTE INT NO VA PERO SI NO TIRA ERROR

                data.Rows.Add(row);


               
            }                        
             return data;


           
        }

    }
}


