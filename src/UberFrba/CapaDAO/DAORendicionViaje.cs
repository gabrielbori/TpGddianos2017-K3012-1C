using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UberFrba.CapaDAO
{
    class DAORendicionViaje : SqlConnector
    {

        public static DataTable getTurnos()
        {
            return retrieveDataTable("GET_TURNOS");
        }

        public static DataTable getViajes(int idChofer, DateTime fecha, int idTurno)
        {

            return retrieveDataTable("GET_VIAJES_A_PAGAR", idChofer, fecha, idTurno);
        }


        
    }
}
