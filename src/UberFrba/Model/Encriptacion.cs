using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace UberFrba.Model
{
    class Encriptacion
    {
        public static string getSHA256(string input)
        {
            var hash = SHA256.Create();

            // Convertir la cadena en un array de bytes y calcular hash
            var data = hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Copiar cada elemento del array a un
            // StringBuilder en formato hexadecimal

            var sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }
    }
}
