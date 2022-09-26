using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesAndBucles.Codigo {
    public class _01_logica_booleana {
        public void logicaBooleana() {
            var num = 5;
            var num2 = 6;

            var result = num == num2;
            Console.WriteLine($"¿Es igual { num }  y { num2 }? { result }");

            var result2 = num != num2;
            Console.WriteLine($"¿Son diferentes { num }  y { num2 }? { result2 }");

            var result3 = num < num2;
            Console.WriteLine($"¿{ num } es menor que { num2 }? { result3 }");

            var result4 = num > num2;
            Console.WriteLine($"¿{ num } es mayor que { num2 }? { result4 }");

            var nombre = "Fer Santi";
            var result5 = nombre is null;
            var result6 = nombre is not null;

            Console.WriteLine($"¿Es nulo { nombre }? { result5 }");
            Console.WriteLine($"¿No es nulo { nombre }? { result6 }");
        }
    }
}
