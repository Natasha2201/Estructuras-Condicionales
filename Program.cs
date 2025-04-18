using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsolaTipoDatos
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine($"--------------TIPOS DE DATOS--------------------");

            int entero = 10;

            double flotante = 20.5;

            bool booleano = true;

            char caracter = 'C';

            string texto = "Ejemplo";



            Console.WriteLine($"Entero: {entero}");

            Console.WriteLine($"Flotante: {flotante}");

            Console.WriteLine($"Booleano: {booleano}");

            Console.WriteLine($"Caracter: {caracter}");

            Console.WriteLine($"Texto: {texto}");


            Console.ReadKey(); 

            Console.WriteLine($"--------------CONVERSION DE DATOS--------------------");

            double valorDouble = 12.78;

            int valorEntero = (int)valorDouble;

            string numeroTexto = "50";

            int numeroEntero = Convert.ToInt32(numeroTexto);



            Console.WriteLine($"Valor entero (casting): {valorEntero}");

            Console.WriteLine($"Número convertido: {numeroEntero}");


            Console.ReadKey(); 


            Console.WriteLine($"--------------ESTRUCTURAS CONDICIONALES--------------------");

            int edad = 22;



            if (edad >= 18)

                Console.WriteLine("Es adulto");

            else

                Console.WriteLine("Es menor");



            Console.ReadKey(); 

            Console.WriteLine($"-------------switch-case --------------------");
            
            int opcion = 2;

            switch (opcion)

            {

                case 1:

                    Console.WriteLine("Opción 1");

                    break;

                case 2:

                    Console.WriteLine("Opción 2");

                    break;

                default:

                    Console.WriteLine("Otra opción");

                    break;

            }
            
            Console.ReadKey(); 


            Console.WriteLine($"-------------Ciclo while--------------------");

            int contador1 = 0;

            while (contador1 < 3)

            {

                Console.WriteLine($"Contador: {contador1}");

                contador1++;

            }

            Console.ReadKey(); 


            Console.WriteLine($"-------------Ciclo do-while--------------------");

            int contador = 0;

            do
            {

                Console.WriteLine($"Contador: {contador}");

                contador++;

            } while (contador < 3);

            Console.ReadKey();
        }
    }
}
