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
    class DAORegistroViaje :SqlConnector
    {

        //OBTIENE LOS TURNOS
        public static DataTable getTurnos()
        {
            return retrieveDataTable("GET_TURNOS");
        }
    }
}
