using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesAndBucles.Codigo {
    public class _06_patrones_relaciones_logicos {
        public void patrones() {
            /* Relaciones */
            double temperatura = 37.7;

            var mensaje = temperatura switch {
                37 => "¡No tienes condición!",
                > 37 => "¡Tienes fiebre!",
                < 37 => "¡Puede que tengas baja el azúcar!"
            };

            Console.WriteLine(mensaje);

            /* Lógicos */
            /* Operador Not */
            string? apellido = "Nicolás";

            if (apellido is not null)
            {
                Console.WriteLine(apellido.ToUpper());
            }

            Console.WriteLine("Fin del programa!");

            /* Operador And */
            var calificacion = 9;
            var calFinal = calificacion switch
            {
                < 6 => "Tienes NA",
                >= 6 and < 7 => "Tiene S",
                <= 7 and <= 8 => "Tienes B",
                > 8 and <= 10 => "Tienes MB"
            };

            Console.WriteLine(calFinal);

            /* Operador Or */
            var fechaAct = DateTime.Today;
            var estacion = fechaAct.Month switch
            {
                3 or 4 or 5 => "Primavera",
                6 or 7 or 8 => "Verano",
                9 or 10 or 11 => "Otoño",
                12 or 1 or 2 => "Invierno",
                _ => throw new ApplicationException("Mes incorrecto!")
            };

            Console.WriteLine(estacion);
        }
    }
}
