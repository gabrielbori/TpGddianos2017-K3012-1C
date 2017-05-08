using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Model
{
    class Rol
    {
         public int ID { get; set; }
        public string Nombre { get; set; }
        public byte Habilitado { get; set; }
        public List<int> Funcionalidades; 

        public Rol(string nombre)
        {
            Nombre = nombre;
        }

        public Rol(int cod, string nombre, byte habilitado)
        {
            ID = cod;
            Nombre = nombre;
            Habilitado = habilitado;
        }

        public Rol(string nombre, List<int> funcionalidades)
        {
            Nombre = nombre;
            Funcionalidades = funcionalidades;
            Habilitado = 1;
        }

       
    }

    enum Roles : int
    {
        Admin = 1,
        Usuario = 2
    }
    
}
