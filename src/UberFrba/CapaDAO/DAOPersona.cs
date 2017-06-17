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
        public static DataTable getPersona(string nombre, string apellido, string nroDoc,string tipoPersona)
        {
            return retrieveDataTable("FIND_PERSONA", nombre, apellido, nroDoc, tipoPersona);
            
        }

        public static DataTable getPersonaActiva(string nombre, string apellido, string nroDoc, string tipoPersona)
        {
            return retrieveDataTable("FIND_PERSONA_ACTIVA", nombre, apellido, nroDoc, tipoPersona);
                 
        }

        public static bool choferActivo(int dni, string nombre)
        {
            int cant = executeProcedureWithReturnValue("CHOFER_ACTIVO", dni, nombre);

            if (cant == 0)
            {return false;}
            else{return true;}
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
                               row["PERS_MAIL"] as string     
                               );
                               
        }

        public static bool existeTelefono(int telefono, int dni, string tipo)
        {

            int cant = (executeProcedureWithReturnValue("GET_TELEFONO", telefono, dni, tipo));

            if ( cant == 0)
                return false;
            else
                return true;
        }


        public static void ModificarPersona(Persona persona, int id, int rolId, int estado,string codPostal)
        {
            executeProcedure("MODIFICAR_PERSONA",
                id,
                persona.Telefono,
                persona.Nombre,
                persona.Apellido,
                persona.Dni,
                persona.Direccion,
                Convert.ToDateTime(persona.FechaDeNacimiento),
                persona.Mail,
                estado,
                codPostal,
                rolId);

        }

        public static void bajaPersona(int id, string tipo)
        {
            executeProcedure("BAJA_PERSONA", id, tipo);
        }

        public static void altaPersona(int telefono, string nombre, string apellido, int dni, DateTime fechaNacimineto, string direccion, string mail, string codPos, string tipo)
        {
            executeProcedure("ALTA_PERSONA", telefono, nombre, apellido, dni, fechaNacimineto, direccion, mail, codPos, tipo);
        }

        public static void actualizarPersona(int dni, int tipoASetear, string codPos, int rol)
        {
            executeProcedure("ACTUALIZAR_PERSONA", dni, tipoASetear, codPos, rol);
        }
        
        public static int getTipo(int dni)
        {

            DataTable table = retrieveDataTable("GET_TIPO_POR_DNI", dni);
            try
            {
                DataRow row = table.Rows[0];
                return (Convert.ToInt32(row["PERS_TIPO"]));
            }
            catch {
                return 0;
            }


        }

        public static bool existePersona(int dni, string tipo)
        {
            return checkIfExists("GET_PERSONA_POR_DNI", dni, tipo);
        }

        public static void actuaizarTipoPersona(int telefono, string codigoPostal, string tipo)
        {
            executeProcedure("ACTUALIZAR_TIPO_PERSONA", telefono, codigoPostal, tipo);
        }

        public static string getCodigoPostal(int id)
        {
            try{
            DataTable table = retrieveDataTable("GET_CODIGO_POSTAL", id);
            return (table.Rows[0])["CODIGOPOSTAL"] as string;
            }catch{ return "";}
        }

        public static bool estadoDePerfil(int telefono, int dni, string tipo)
        {

            int estado = (executeProcedureWithReturnValue("GET_ESTADO_PERFIL", telefono, dni, tipo));

            if (estado == 0)
                return true;
            else
                return false;
        }

    }
}