using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionesAndBucles.Codigo {
    public class _04_operador_ternario {
        public void operadorTernario() {
            bool usuarioLogueado = false;

            string mensaje = usuarioLogueado ? "¡Bienvenido al Sistema!" : "¡Inicia Sesión para comenzar!";
            Console.WriteLine(mensaje);
        }  
    }
}
