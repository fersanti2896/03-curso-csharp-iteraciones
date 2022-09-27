using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesAndBucles.Codigo {
    public class _09_ciclo_for_foreach {
        public void cicloFor() {
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"Valor: { i }");
            }

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"Bucle For");
            }
        }

        public void cicloForEach() {
            string nombre = "Fer Santi";

            foreach (var letra in nombre) {
                Console.WriteLine($"Caracter: { letra }");
            }
        }  
    }
}
