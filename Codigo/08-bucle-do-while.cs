using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesAndBucles.Codigo {
    public class _08_bucle_do_while {
        public void bucleDoWhile() {
            var contador = 10;

            do {
                Console.WriteLine($"Valor: { contador }");
            } while (contador > 10);
        }
    }
}
