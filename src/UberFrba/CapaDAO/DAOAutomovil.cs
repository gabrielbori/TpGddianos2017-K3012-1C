using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using UberFrba.Model;

namespace UberFrba.CapaDAO
{
    class DAOAutomovil : SqlConnector
    {
        public static DataTable getMarcas()
        {
            return retrieveDataTable("GET_MARCAS");
        }

        public static DataTable getModelos(string marca)
        {
            return retrieveDataTable("GET_MODELOS", marca);
        }

        public static DataTable getPatentes(string marca)
        {
            return retrieveDataTable("GET_PATENTES", marca);
        }

        public static DataTable getEstadoYChofer(string patente)
        {
            return retrieveDataTable("GET_ESTADO_CHOFER", patente);
        }

    }
}
