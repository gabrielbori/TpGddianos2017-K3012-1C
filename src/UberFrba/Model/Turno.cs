using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UberFrba.Model
{
    class Turno
    {
        public int id { get; set; }
        public int horaInicio { get; set; }
        public int horaFin { get; set; }
        public string descripcion { get; set; }
        public double valorKm { get; set; }
        public double precioBase { get; set; }
        public int estado { get; set; }

        public Turno(int ID, int HORAINICIO, int HORAFIN, string DESCRIPCION, double VALORKM, double PRECIOBASE, int ESTADO)
        {
            id = ID;
            horaInicio = HORAINICIO;
            horaFin = HORAFIN;
            descripcion = DESCRIPCION;
            valorKm = VALORKM;
            precioBase = PRECIOBASE;
            estado = ESTADO;
        }

    }
}
