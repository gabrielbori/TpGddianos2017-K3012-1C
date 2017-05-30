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
    class DAOTurno : SqlConnector
    {
        public static int altaTurno(string descripcion, double hi, double hf, double valor, double precio)
        {
            return executeProcedureWithReturnValue("ALTA_TURNO", descripcion, hi, hf, valor, precio);
            
        }

        public static DataTable getDetalleTurnos()
        {
            return retrieveDataTable("GET_DETALLE");
        }

        public static Turno getHoraInicioTurnos(string descripcion)
        {
            DataTable table = retrieveDataTable("GET_HORARIOS", descripcion);

            return dataRowToTurno(table.Rows[0]);
        }

        public static void bajaTurnoPorDescripcionYHorarios(string descripcion, int hi, int hf)
        {
            executeProcedure("BAJA_TURNO", descripcion, hi, hf);
        }

        public static Turno dataRowToTurno(DataRow row)
        {
            return new Turno (Convert.ToInt32(row["TURNO_ID"]),
                               Convert.ToInt32(row["TURNO_HORA_INICIO"]),
                               Convert.ToInt32(row["TURNO_HORA_FIN"]),
                               row["TURNO_DESCRIPCION"] as string,
                               Convert.ToInt32(row["TURNO_VALOR_KM"]),
                               Convert.ToInt32(row["TURNO_PRECIO_BASE"]),
                               Convert.ToInt32(row["TURNO_ESTADO"]));
        }

        public static DataTable getTurnoPorId(int id)
        {
            return retrieveDataTable("FIND_TURNO_ID", id);
        }

        public static DataTable getTurnoDescripcion(string descripcion)
        {
            return retrieveDataTable("FIND_TURNO_DESCRIPCION", descripcion);
        }

        public static int modificarTurno(Turno turno, int id)
        {
            return executeProcedureWithReturnValue("MODIFICAR_TURNO", id, turno.horaInicio, turno.horaFin, turno.descripcion, turno.valorKm, turno.precioBase, turno.estado);
        }
    }
}
