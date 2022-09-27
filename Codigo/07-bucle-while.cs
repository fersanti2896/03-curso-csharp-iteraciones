using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesAndBucles.Codigo {
    public class _07_bucle_while {
        public void bucleWhile() {
            var cantidad = 1;

            while (cantidad <= 10) {
                Console.WriteLine($"Valor: { cantidad }");
                cantidad++;
            }

            var valor = 1;

            while (valor <= 10) {
                Console.WriteLine($"{ valor } x { 1 } = { valor * 1 }");
                valor++;
            }
        }    
    }
}
