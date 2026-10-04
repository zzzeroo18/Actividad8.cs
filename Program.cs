using System;
using System.Diagnostics.CodeAnalysis;

namespace Actividad8Limpia
{
    class Program
    {
        static void Main()
        {
            // 1. crear metodo saludar(string nombre) que imprima mensaje.
            Console.WriteLine("consigna 1");
            darbienvenida("ticher lucio");

            // 2. crear metodo sumar(int a, int b) que retorne la suma.
            Console.WriteLine("consigna 2");
            int totalsuma = calcularsuma(12, 123);
            Console.WriteLine("resultado de la suma: " + totalsuma);

            // 3. crear metodo espar(int n) que retorne bool.
            Console.WriteLine("consigna 3");
            bool esnumeroimparoparbe = chequearpar(6);
            Console.WriteLine("¿el numero es par? " + esnumeroimparoparbe);

            // 4. crear metodo mayor(int a, int b) que retorne el mayor.
            Console.WriteLine("consigna 4");
            int valorresmax = obtenermayor(100, 99);
            Console.WriteLine("el mayor es: " + valorresmax);

            // 5. crear metodo calcularfactorial(int n) con bucle.
            Console.WriteLine("consigna 5");
            int resfactorial = obtenerfactorial(10);
            Console.WriteLine("el factorial del numero es: " + resfactorial);

            // 6. crear metodo con valor por defecto en parametro.
            Console.WriteLine("consigna 6");
            imprimirdefecto();

            // 7. demostrar scope: variable declarada en metodo no existe afuera.
            Console.WriteLine("consigna 7");
            demostrarscope();
            // Console.WriteLine(varalmacenada); // lo deje como comentario para ir probando el resto del codigo

            // 8. crear metodo imprimirarray(int[] arr) que muestre todos los elementos.
            Console.WriteLine("consigna 8");
            int[] arreglonumerico = { 3, 7, 1, 9, 4 };
            mostrarvector(arreglonumerico);

            // 9. crear metodo contarpares(int[] arr) que retorne cuantos pares hay.
            Console.WriteLine("consigna 9");
            int[] datosvector = { 3, 6, 1, 9, 4, 8, 2 };
            int cantpares = obtenercantpares(datosvector);
            Console.WriteLine("hay " + cantpares + " numero pares");

            // 10. separar el codigo del ejercicio anterior en 3 metodos distintos.
            Console.WriteLine("consigna 10");
            int[] datosvector2 = { 100, 100000000, 21, 31, 53, 67, 67, 41 };
            int canttotalpares = procesarpares(datosvector2);
            imprimirresultado(canttotalpares);
        }

        // consigna 1
        static void darbienvenida(string nombredato)
        {
            Console.WriteLine("hola " + nombredato);
        }

        // consigna 2
        static int calcularsuma(int valora, int valorb)
        {
            return valora + valorb;
        }

        // consigna 3
        static bool chequearpar(int datonum)
        {
            return datonum % 2 == 0;
        }

        // consigna 4
        static int obtenermayor(int primerentero, int segundoentero)
        {
            if (primerentero > segundoentero)
            {
                return primerentero;
            }
            else
            {
                return segundoentero;
            }
        }

        // consigna 5
        static int obtenerfactorial(int limite)
        {
            int resultadoacum = 1;
            for (int i = 1; i <= limite; i++)
            {
                resultadoacum = resultadoacum * i;
            }
            return resultadoacum;
        }

        // consigna 6
        static void imprimirdefecto(int valoropcional = 20)
        {
            Console.WriteLine(valoropcional);
        }

        // consigna 7
        static void demostrarscope()
        {
            int varalmacenada = 10;
            Console.WriteLine(varalmacenada);
        }

        // consigna 8
        static void mostrarvector(int[] elementosvector)
        {
            for (int i = 0; i < elementosvector.Length; i++)
            {
                Console.WriteLine(elementosvector[i]);
            }
        }

        // consigna 9
        static int obtenercantpares(int[] arreglopares)
        {
            int contadorpares = 0;

            for (int i = 0; i < arreglopares.Length; i++)
            {
                if (arreglopares[i] % 2 == 0)
                {
                    contadorpares++;
                }
            }
            return contadorpares;
        }

        // consigna 10
        static bool validarparidad(int n)
        {
            return n % 2 == 0;
        }

        static int procesarpares(int[] arregloelementos)
        {
            int contadorpares = 0;

            for (int i = 0; i < arregloelementos.Length; i++)
            {
                if (validarparidad(arregloelementos[i]))
                {
                    contadorpares++;
                }
            }

            return contadorpares;
        }

        static void imprimirresultado(int totalres)
        {
            Console.WriteLine($"cantidad de pares: {totalres}");
        }
    }
}