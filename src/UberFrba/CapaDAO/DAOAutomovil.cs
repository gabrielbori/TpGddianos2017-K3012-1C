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

        public static void bajaAutomovilPorPatente(string patente)
        {
            executeProcedure("BAJA_AUTOMOVIL_POR_PATENTE", patente);
        }

        public static bool validarPatente(string patente)
        {
            return checkIfExists("GET_AUTOMOVIL_POR_PATENTE", patente);
        }

        public static void modificarAutomovilPorPatente(string patente, int estado /*,chofer*/ )
        {
            executeProcedure("MODIFICAR_AUTOMOVIL_POR_PATENTE", patente, estado /*, chofer*/);
        }

        public static bool validarChofer(string chofer)
        {
            return false;
        }

        public static void altaAutomovil(string marca, string modelo, string patente, string chofer, int estado)
        {
            executeProcedure("ALTA_AUTOMOVIL", marca, modelo, patente, chofer, estado);
        }
    }
}
