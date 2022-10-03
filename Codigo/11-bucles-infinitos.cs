using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesAndBucles.Codigo {
    public class _11_bucles_infinitos {
        public void buclesInfinitos() {
            while (true) {
                Console.WriteLine("¡Bienvenido al programa de calculadora!");
                Console.Write("Escribe el primer número a sumar: ");
                var entrada = Console.ReadLine();

                if (entrada is null) {
                    Console.WriteLine("Error, vuelva a comenzar");
                    continue;
                }

                var num1 = decimal.Parse(entrada);

                Console.Write("Escriba el segundo número a sumar: ");
                entrada = Console.ReadLine();

                if (entrada is null) {
                    Console.WriteLine("Error, vuelva a comenzar");
                    continue;
                }

                var num2 = decimal.Parse(entrada);
                var result = num1 + num2;

                Console.WriteLine($"La suma de { num1 } + { num2 } es { result }");
                Console.Write("¿Deseas volver a usar la calculadora de suma? (Y/N) ");
                entrada = Console.ReadLine().ToUpper();

                if (entrada != "Y") {
                    break;
                }
            }
        }
    }
}
