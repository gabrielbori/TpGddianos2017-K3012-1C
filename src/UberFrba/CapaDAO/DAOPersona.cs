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
    class DAOPersona : SqlConnector
    {
        public static DataTable getPersona(string nombre, string apellido, string nroDoc,int tipoPersona)
        {
            return retrieveDataTable("FIND_PERSONA", nombre, apellido, nroDoc, tipoPersona);
        }

        public static DataTable getPersona(int id)
        {
            return retrieveDataTable("GET_PERSONA", id);
        }

        public static Persona dataRowToPersona(DataRow row)
        {
            return new Persona(Convert.ToInt32(row["PERS_ID"]),
                               Convert.ToInt32(row["PERS_TELEFONO"]),
                               row["PERS_NOMBRE"] as string,
                               row["PERS_APELLIDO"] as string,
                               Convert.ToInt32(row["PERS_DNI"]),
                               row["PERS_DIRECCION"] as string,
                               Convert.ToDateTime(row["PERS_FECHA_NACIM"]),
                               Convert.ToInt32(row["PERS_ESTADO"]),
                               row["PERS_MAIL"] as string,
                               Convert.ToInt32(row["PERS_TIPO"]),
                               row["PERS_COD_POSTAL"] as string);
                               
        }

        public static bool existeTelefono(int telefono, int dni)
        {
            return checkIfExists("GET_TELEFONO", telefono, dni);
        }

        public static void ModificarPersona(Persona persona, int id)
        {
            executeProcedure("MODIFICAR_PERSONA",
                id,
                persona.Nombre,
                persona.Apellido,
                persona.Dni,
                persona.Direccion,
                persona.FechaDeNacimiento,
                persona.Mail,
                persona.Telefono,
                persona.Estado,
                persona.CodigoPostal
                );
        }

        public static void bajarPersona(int id)
        {
            executeProcedure("BORRAR_PERSONA", id);
        }

    }
}