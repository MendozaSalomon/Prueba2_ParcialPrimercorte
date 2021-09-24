using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba2_ParcialPrimercorte
{
    public class contrario
    {

        public string Invertir(string cadena)
        {
            // Convertir a arreglo
            char[] cadenaComoCaracteres = cadena.ToCharArray();
            // Invertir el arreglo usando métodos incorporados
            Array.Reverse(cadenaComoCaracteres);
            // Convertir de nuevo el arreglo a cadena
            return new string(cadenaComoCaracteres);


        }


    }

}
