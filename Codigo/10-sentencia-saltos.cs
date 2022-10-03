using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesAndBucles.Codigo {
    public class _10_sentencia_saltos {
        public void sentencia_saltos() {
            for (int i = 1; i <= 10; i++) {
                if (i == 5)
                    break;

                Console.WriteLine(i);
            }
            Console.WriteLine("¡Fin del primer For!");

            for (int i = 1; i <= 10; i++) {
                if (i == 5)
                    continue;

                Console.WriteLine(i);
            }
            Console.WriteLine("¡Fin del segundo For!");

            Console.WriteLine("¡Fin del programa!");
        }
    }
}
