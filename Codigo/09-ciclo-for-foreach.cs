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

            for (int i = 1; i <= 15; i++) {
                if (i % 15 == 0) {
                    Console.WriteLine("fizzbuzz");
                } else if (i % 3 == 0) {
                    Console.WriteLine("fizz");
                } else if (i % 5 == 0) {
                    Console.WriteLine("buzz");
                } else {
                    Console.WriteLine($"{ i } ");
                }
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
