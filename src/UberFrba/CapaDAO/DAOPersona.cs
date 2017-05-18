using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UberFrba.CapaDAO
{
    class DAOPersona : SqlConnector
    {
        public static DataTable getPersona(string nombre, string apellido, string nroDoc,int tipoPersona)
        {
            return retrieveDataTable("FIND_PERSONA", nombre, apellido, nroDoc, tipoPersona);
        }
    }
}