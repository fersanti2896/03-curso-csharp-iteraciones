using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesAndBucles.Codigo {
    public class _02_operaciones_condicionales_bool {
        public void operacionesCondicionalesBooleanos() {
            var cantidad = 5;
            var validacion = cantidad >= 5 && cantidad < 10;
            Console.WriteLine($"¿Esta { cantidad } está en el rango [5, 10]? { validacion }");

            var validacion2 = cantidad == 5 || cantidad == 6;
            Console.WriteLine($"¿Es { cantidad } igual a 5 o 6? { validacion2 }");

            string apellido = "Santiago";
            var validacion3 = apellido == apellido.ToUpper();
            Console.WriteLine($"¿Está en mayúsculas { apellido }? { validacion3 }");
        }
    }
}
