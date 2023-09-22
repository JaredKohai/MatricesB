using System; //

namespace MatricesB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Elige una opción:");
                Console.WriteLine("1. Calcular matrices");
                Console.WriteLine("2. Salir");
                int opcionPrincipal = Convert.ToInt32(Console.ReadLine());

                if (opcionPrincipal == 2)
                    break;

                if (opcionPrincipal != 1)
                {
                    Console.WriteLine("Opción no válida. Por favor, elige una opción válida.");
                    continue;
                }

                Console.WriteLine("Ingresa la primera matriz:");
                Matriz matriz1 = CrearMatrizCO();

                Console.WriteLine("Presiona cualquier tecla para ingresar la segunda matriz.");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Ingresa la segunda matriz:");
                Matriz matriz2 = CrearMatrizCO();
                Matriz matrizOriginal1 = new Matriz(matriz1);
                Matriz matrizOriginal2 = new Matriz(matriz2);

                Console.Clear();
                Console.WriteLine($"Matriz 1:");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                matriz1.MostrarMatriz();
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Matriz 2:");
                Console.ForegroundColor = ConsoleColor.Green;
                matriz2.MostrarMatriz();
                Console.ForegroundColor = ConsoleColor.White;

                while (true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Elige una operación:");
                    Console.WriteLine("1. Suma");
                    Console.WriteLine("2. Resta");
                    Console.WriteLine("3. Multiplicación");
                    Console.WriteLine("4. Dividir");
                    Console.WriteLine("<--------------------------------->".PadLeft(80));
                    Console.WriteLine("5. Regresar a matriz original");
                    Console.WriteLine("6. Calcular otras matrices");
                    Console.WriteLine("7. Salir");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    if (opcion == 7)
                        break;

                    if (opcion == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        matriz1 = new Matriz(matrizOriginal1);
                        matriz2 = new Matriz(matrizOriginal2);
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Matrices restauradas!".PadLeft(80));
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Matriz 1:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        matriz1.MostrarMatriz();
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Matriz 2:");
                        Console.ForegroundColor = ConsoleColor.Green;
                        matriz2.MostrarMatriz();
                        Console.ForegroundColor = ConsoleColor.White;
                        continue;
                    }

                    if (opcion == 6)
                        break;

                    Matriz resultado = RealizarOperacion(matriz1, matriz2, opcion);
                    if (resultado != null)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Resultado:".PadLeft(60));
                        Console.ForegroundColor = ConsoleColor.Green;
                        resultado.MostrarMatriz();
                    }
                    else
                    {
                        Console.WriteLine("Selecciona una opción correcta");
                    }
                }
            }
        }

        static Matriz CrearMatrizCO()
        {
            Console.WriteLine("Número 1: ");
            double elemento1 = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Número 2: ");
            double elemento2 = Convert.ToDouble(Console.ReadLine()); 
            Console.WriteLine("Número 3: ");
            double elemento3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Número 4: ");
            double elemento4 = Convert.ToDouble(Console.ReadLine());

            double[,] matriz = { { elemento1, elemento2 }, { elemento3, elemento4 } };
            return new Matriz(matriz);
        }

        static Matriz RealizarOperacion(Matriz matriz1, Matriz matriz2, int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    return matriz1.Sumar(matriz2);
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    return matriz1.Restar(matriz2);
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    return matriz1.Multiplicar(matriz2);
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    return matriz1.División(matriz2);

                default:
                    return null;
            }
        }
    }
}