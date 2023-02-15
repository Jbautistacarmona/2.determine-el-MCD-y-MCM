using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.determine_el_MCD_y_MCM
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calcular MCD y MCM"); //mensaje en pantalla al usuario.
            Console.WriteLine("--------------------");

            Console.Write("Ingrese el primer número: ");//Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente.
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");//Convierte la representación en forma de cadena de un número en el entero de 32 bits con signo equivalente.
            int num2 = int.Parse(Console.ReadLine());

            int gcd = GetGCD(num1, num2); //variable local
            Console.WriteLine("\nEl MCD es: " + gcd);

            int lcm = num1 * num2 / gcd;
            Console.WriteLine("El MCM es: " + lcm); //imprimir mensaje en pantalla.

            Console.WriteLine("\nPresione cualquier tecla para salir...");
            Console.ReadKey();
        }

        static int GetGCD(int a, int b)
        {
            if (b == 0)//la bifurcación condicional. El cuerpo de una instrucción if se ejecuta si el valor de la expresión es distinto de cero.
            {
                return a;//nos devuelve el valor.
            }
            else//Es usada para ejecutar una instrucción o bloque de instrucciones solo si una condición es cumplida
            {
                return GetGCD(b, a % b);
            }
        }
    }
}