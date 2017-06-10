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

        public static void modificarAutomovilPorPatente(string patente, int estado, int chofer)
        {
            executeProcedure("MODIFICAR_AUTOMOVIL_POR_PATENTE", patente, estado, chofer);
        }

        public static void ingresarTurnoAutomovilPorPatente(string patente, string detalle)
        {
            executeProcedure("INGRESAR_TURNO_AUTOMOVIL_POR_PATENTE", patente, detalle);
        }

        public static void modificarTurnoAutomovilPorPatente(string patente, string detalle, int estado)
        {
            executeProcedure("MODIFICAR_TURNO_AUTOMOVIL_POR_PATENTE", patente, detalle, estado);
        }

        public static bool choferAsignado (int chofer, string patente)
        {
            return checkIfExists("CHOFER_ASIGNADO", chofer, patente);
        }

        public static void altaAutomovil(string marca, string modelo, string patente, int chofer, int estado)
        {
            executeProcedure("ALTA_AUTOMOVIL", marca, modelo, patente, chofer, estado);
        }
    }
}
