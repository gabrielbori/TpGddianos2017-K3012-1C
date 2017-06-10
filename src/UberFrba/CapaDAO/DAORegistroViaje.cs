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

       
        public static DataTable getTurnosAuto(string patente)
        {
            return retrieveDataTable("GET_TURNOS_AUTO", patente);
        }
        
        public static DataTable getAutos(int choferDNI)
        {
            return retrieveDataTable("GET_AUTOS_ACTIVOS_DE_CHOFER", choferDNI);
        }

        public static void registrarViaje(int turno, DateTime fecha, DateTime horaI, DateTime horaF ,decimal km, int chofer, int cliente) 
        {
            executeProcedure("REGISTRAR_VIAJE", turno,  fecha,  horaI,  horaF, km,  chofer,  cliente);
        }

        public static int viajeYaRegistrado(DateTime fecha, DateTime horaI, int cliente)
        {
            return executeProcedureWithReturnValue("VIAJE_YA_REGISTRADO", fecha, horaI, cliente);
        }
    }
}
