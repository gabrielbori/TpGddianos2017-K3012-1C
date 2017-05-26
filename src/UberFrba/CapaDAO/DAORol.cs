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
    class DAORol : SqlConnector
    {

        public static RolUsuario getRolUsuario(int id, int tipo)
        {
            RolUsuario rol;

            DataTable table = retrieveDataTable("GET_ROLES_USUARIO_POR_ID", id, tipo);

            return rol = dataRowToPersona(table.Rows[0]);
        }

     

        public static RolUsuario dataRowToPersona(DataRow row)
        {
            RolUsuario rol = new RolUsuario (row["ROL_USUA_USERNAME"] as string,
                               Convert.ToInt32(row["ROL_ROL_ID"]),
                               Convert.ToInt32(row["ROL_ROL_ESTADO"]));
            return rol;

        }

        public static DataTable getRoles()
        {
             
            return retrieveDataTable("GET_ROLES");
                        
        }

        public static DataTable getFuncionalidades(int id)
        {
            return retrieveDataTable("GET_FUNCIONALIDADES_ROL",id);
        }

        public static int getId(string nombre)
        {

            DataTable table = retrieveDataTable("GET_ROL_POR_NOMBRE", nombre);

  
            
            return  dataRowToEstado(table.Rows[0]);
        }

        public static int dataRowToEstado(DataRow row)
        {
            return Convert.ToInt32(row["ROL_ID"]);
                              
        }

        public static void bajaRolSeleccionado (string rol)
        {
            executeProcedure("BAJA_ROL", rol);
        }

        public static void altaRol(string nombre)
        {
            executeProcedure("ALTA_ROL", nombre);
            //executeProcedure("ALTA_FUNCIONALIDAD_POR_ROL",)
        }


        public static string getRol(string nombre)
        {
            DataTable table = retrieveDataTable("FIND_ROL", nombre);
            try
            {
                DataRow row = table.Rows[0];
                return ((row["ROL_NOMBRE"].ToString()));
            }
            catch
            {
                return "El rol ya existe";
            }


        }
        public static Funcionalidad dataRowToFuncionalidad(DataRow row)
        {
            return new Funcionalidad (Convert.ToInt32(row["FUNCIONALIDAD_ID"]),                               
                               row["Funcionalidad"] as string);

        }
    }
}
