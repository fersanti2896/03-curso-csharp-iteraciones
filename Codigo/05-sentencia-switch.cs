using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesAndBucles.Codigo {
    public class _05_sentencia_switch {
        public void sentenciaSwitch() {
            Console.WriteLine("¡BIENVENIDO AL SISTEMA!");
            Console.WriteLine(@"Seleccina una opción: 
                1. Inicia Sesión
                2. Leer Términos y Condiciones
                3. Salir
            ");

            string opc = Console.ReadLine();

            switch (opc) {
                case "1":
                    Console.WriteLine("¡Bienvenido al Sistema!");
                    break;
                case "2":
                    Console.WriteLine("¡Son las reglas de negocio!");
                    break;
                case "3":
                    Console.WriteLine("¡Vuelve pronto!");
                    break;
                default:
                    Console.WriteLine("¡Error al capturar opción!");
                    break;
            }
        }   
    }
}
