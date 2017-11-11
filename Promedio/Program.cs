using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Promedio
    {
        class Program
        {
            static void Main(string[] args)
            {
                int calificacion = 1;
                int acumulador = 0;
                int n = 0;
                while (calificacion > 0)
                {
                    Console.WriteLine("Introduce tu calificacion: ");
                    calificacion = int.Parse(Console.ReadLine());
                    acumulador = acumulador + calificacion;
                    n = n + 1;
                }
                int promedio;
                Console.WriteLine("La suma de tu calificacion es: " + acumulador);
                promedio = acumulador / n;

                Console.WriteLine("Tu promedio es: " + promedio);
                Console.ReadKey();
            }

        }
    }


}
