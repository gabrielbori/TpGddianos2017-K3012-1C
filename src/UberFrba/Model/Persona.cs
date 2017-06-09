using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Model
{
    public class Persona
    {

        public int ID { get; set; }
        public int Telefono { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Dni { get; set; } 
        public string Direccion { get; set; }
        public DateTime FechaDeNacimiento { get; set; }
        public int Estado { get; set; }
        public string Mail { get; set; }
        public int Tipo { get; set; }
        public string CodigoPostal { get; set; }

        public Persona(int id, int telefono, string nombre, string apellido, int dni, string direccion
                       , DateTime fecha_nac, int estado, string mail, string codPost)
        {
            ID = id;
            Telefono = telefono;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            FechaDeNacimiento = fecha_nac;
            Estado = estado;
            Mail = mail;
            Tipo = Tipo;
            CodigoPostal = codPost;
        }

        public Persona(int id, int telefono, string nombre, string apellido, int dni, string direccion
                       , DateTime fecha_nac,int estado, string mail, int tipo, string codPost)
        {
            ID = id;
            Telefono = telefono;
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            Direccion = direccion;
            FechaDeNacimiento = fecha_nac;
            Estado = estado;
            Mail = mail;
            Tipo = tipo;
            CodigoPostal = codPost;
        }

        public Persona(string nombre, string apellido, int dni)
        {
            Nombre = nombre;
            Apellido = apellido;
            Dni = dni;
            
        }
    }
}
