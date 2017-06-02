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

        //ALTA BAJA Y MODIFICACION DEL ROL
        public static void bajaRolSeleccionado(string rol, int id)
        {
            executeProcedure("BAJA_ROL", rol, id);
        }

        public static void altaRol(string nombre, DataGridViewRowCollection funcionalidades, int estado)
        {
            executeProcedure("ALTA_ROL", nombre, crearData(funcionalidades),estado);
        }

        public static void modificarRol(int id, string nombre, DataGridViewRowCollection funcionalidades, int estado)
        {
            executeProcedure("MODIFICAR_ROL", id, nombre, crearData(funcionalidades), estado);
        }


        //ROL USUARIO
        public static RolUsuario getRolUsuario(int id, int tipo)
        {
            RolUsuario rol;

            try
            {
                DataTable table = retrieveDataTable("GET_ROLES_USUARIO_POR_ID", id, tipo);

                return rol = dataRowToPersona(table.Rows[0]);
            }
            catch
            {
                MessageBox.Show("La persona seleccionada no posee roles asignados", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static RolUsuario dataRowToPersona(DataRow row)
        {
            RolUsuario rol = new RolUsuario (row["ROL_USUA_USERNAME"] as string,
                               Convert.ToInt32(row["ROL_ROL_ID"]),
                               Convert.ToInt32(row["ROL_ROL_ESTADO"]));
            return rol;
        }

        //OBTENER TODOS LOS ROLES
        public static DataTable getRoles()
        {
            return retrieveDataTable("GET_ROLES");                      
        }

       //OBTENER ROLES HABILITADOS
        public static DataTable getRolesHabilitados()
        {
            return retrieveDataTable("GET_ROLES_HABILITADOS");
        }

        //OBTENER EL ID DE UN ROL SEGUN EL NOMBRE
        public static int getId(string nombre)
        {
            DataTable table = retrieveDataTable("GET_ROL_POR_NOMBRE", nombre);
            return dataRowToId(table.Rows[0]);
        }

        public static int dataRowToId(DataRow row)
        {
            return Convert.ToInt32(row["ROL_ID"]);
        }

        //VER SI EL ROL YA EXISTE SEGUN EL NOMBRE
        public static string getRol(string nombre)
        {
            DataTable table = retrieveDataTable("FIND_ROL", nombre);
            try
            {
                DataRow row = table.Rows[0];
                return ((row[0].ToString()));
            }
            catch
            {
                return "El rol ya existe";
            }
        }
       
        
        //OBTENER TODAS LAS FUNCIONALIDADES
        public static DataTable getFuncionalidades()
        {
            return retrieveDataTable("GET_FUNCIONALIDADES");
        }

        //OBTENER FUNCIONALIDAD A PARTIR DEL ID DE ROL
        public static DataTable getFuncionalidadesPorRol(int id)
        {
            return retrieveDataTable("GET_FUNCIONALIDADES_ROL",id);
        }

       
        public static Funcionalidad dataRowToFuncionalidad(DataRow row)
        {
            return new Funcionalidad(Convert.ToInt32(row["ID"]),
                               row["Funcionalidad"] as string);

        }        
    
      

       

        //FUNCIONES AUXILIARES
        private static DataTable crearData(DataGridViewRowCollection integers)
        {
            List<int> ints = new List<int>();

            for (int i = 0; i < integers.Count; i++)
            {
                ints.Add((int)integers[i].Cells["ID"].Value);
            }

            return Globals.intsToDataTable(ints);
        }
    }
}
