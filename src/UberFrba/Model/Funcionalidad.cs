using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Model
{
    class Funcionalidad
    {
        public int ID { get; set; }
        public string Nombre { get; set; }

        public Funcionalidad(int id, string nombre)
        {
            ID = id;
            Nombre = nombre;

        }
    }
    
        
}
