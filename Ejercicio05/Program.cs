namespace Ejercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cuadrada = ObtenerTamaño();

            int[,] matriz = LlenarMatriz(cuadrada);

            MostrarMatriz(matriz);

            CalcularSumas(matriz, cuadrada);
        }

        static int ObtenerTamaño()
        {
            int numero;
            do
            {
                Console.WriteLine("Ingrese un número impar para el tamaño de la matriz cuadrada:");
                numero = Convert.ToInt32(Console.ReadLine());
            } while (numero % 2 == 0);
            return numero;
        }

        static int[,] LlenarMatriz(int numero)
        {
            int[,] matriz = new int[numero, numero];
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el número para la posición [{i + 1}],[{j + 1}]");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matriz;
        }

        static void MostrarMatriz(int[,] matriz)
        {
            Console.WriteLine("\n La matriz cuadrada impar es:");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write("[" + matriz[i, j] + "]");
                }
                Console.WriteLine();
            }
        }

        static void CalcularSumas(int[,] matriz, int cuadrada)
        {
            int mitad = cuadrada / 2;
            int fila = 0;
            int columna = 0;

            
            for (int i = 0; i < cuadrada; i++)
            {
                fila += matriz[mitad, i];
            }
            Console.WriteLine("\n La suma de la fila de la mitad es:" + fila);

            
            for (int j = 0; j < cuadrada; j++)
            {
                columna += matriz[j, mitad];
            }
            Console.WriteLine("\n La suma de la columna de la mitad es:" + columna);

            int suma = columna + fila;
            Console.WriteLine("\n La suma total es:" + suma);
        }
    }
}
