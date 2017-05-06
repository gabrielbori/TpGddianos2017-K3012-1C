using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Windows.Forms;
using System.Data;
using UberFrba.Model;

namespace UberFrba
{
    class Globals
    {
        public static int userID = -1;
        public static string username;
        private static List<int> funcionalidades = new List<int>();

        private static string connectionString = ConfigurationManager.ConnectionStrings["GD1C2015"].ConnectionString;

        public static string getConnectionString()
        {
            return connectionString;
        }

        public static string getFechaSistema()
        {
            return ConfigurationManager.AppSettings["fechaSistema"];
        }

        public static DateTime getDateFechaSistema()
        {
            return Convert.ToDateTime(ConfigurationManager.AppSettings["fechaSistema"]);
        }

        public static DateTime getFechaSistemaEnTipoDate()
        {
            return DateTime.Today;
        }

        public static void setUser(int id, string name, List<int> funcs, int rol)
        {
            if (rol == (int)Roles.Admin)
                userID = 0;
            else
                userID = id;
            username = name;
            funcionalidades = funcs;
        }

        public static bool tieneFuncionalidad(int idFun)
        {
            return funcionalidades.Contains(idFun);
        }

        public static void cerrarSesion()
        {
            userID = 0;
            username = "";
            funcionalidades = new List<int>();
        }

        public static DataTable intsToDataTable(List<int> ints)
        {
            DataTable data = new DataTable();
            data.Columns.Add("ITEM");

            foreach (int num in ints)
            {
                var row = data.NewRow();

                row["ITEM"] = Convert.ToString(num);

                data.Rows.Add(row);
            }
            return data;
        }
    }
    
    }