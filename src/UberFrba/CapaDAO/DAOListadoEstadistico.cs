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
    class DAOListadoEstadistico : SqlConnector
    {
        public static string[] getCampos(string persona, string consulta)
        {
            string[] campos;

            if (String.Equals(persona, "Chofer"))
            {
                //listado de cosas de chofer
                if (String.Equals(consulta, "Recaudacion"))
                {
                    campos = new string[4];
                    campos[0] = "Chofer Nombre";
                    campos[1] = "Chofer Apellido";
                    campos[2] = "Chofer DNI";
                    campos[3] = "Chofer Recaudacion";
                    return campos;
                }
                if (String.Equals(consulta, "Viaje"))
                {
                    campos = new string[4];
                    campos[0] = "Chofer Nombre";
                    campos[1] = "Chofer Apellido";
                    campos[2] = "Chofer DNI";
                    campos[3] = "KM";
                    return campos;
                }
            }


            if (String.Equals(persona, "Cliente"))
            {
                //listado de cosas de cliente
                if (String.Equals(consulta, "Consumo"))
                {
                    campos = new string[4];
                    campos[0] = "Cliente Nombre";
                    campos[1] = "Cliente Apellido";
                    campos[2] = "Cliente DNI";
                    campos[3] = "Cliente Consumo";
                    return campos;
                }
                if (String.Equals(consulta, "Viaje"))
                {
                    campos = new string[5];
                    campos[0] = "Cliente Nombre";
                    campos[1] = "Cliente Apellido";
                    campos[2] = "Cliente DNI";
                    campos[3] = "Automovil";
                    campos[4] = "Cantidad Viajes";
                    return campos;
                }
            }

            return campos = new string [1];
        }

        public static DataTable showListado(int idConsulta,int anio,int trimestre)
        {
            return retrieveDataTable("SHOW_LISTADO",idConsulta,anio,trimestre);
        }
    }
}
