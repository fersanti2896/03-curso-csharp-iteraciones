using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesAndBucles.Codigo {
    public class _03_condicional_if {
        public void condicionalIf()
        {
            var edad = 17;
            Console.WriteLine($"Tu edad es { edad }");

            if (edad >= 18) {
                Console.WriteLine("¡Es mayor de edad!");
            }
            else {
                Console.WriteLine("¡No es mayor de edad!");
            }
        }
    }
}
