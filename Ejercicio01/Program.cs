namespace Ejercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Ingrese el número de filas: ");
            int filas = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el número de columnas: ");
            int columnas = Convert.ToInt32(Console.ReadLine());
     
            int[,] matriz = LlenarMatriz(filas, columnas);

            Console.WriteLine("\nMatriz original:");
            MostrarMatriz(matriz);

            CambiarNegativos(matriz);

            Console.WriteLine("\nMatriz modificada:");
            MostrarMatriz(matriz);


        }

        static int[,] LlenarMatriz(int filas, int columnas)
        {
            int[,] nuevaMatriz = new int[filas, columnas];
            Console.WriteLine("\nIngrese los valores de la matriz:");

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Console.Write($"Elemento [{i},{j}]: ");
                    nuevaMatriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return nuevaMatriz;
        }

        
        static void CambiarNegativos(int[,] matriz)
        {
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        matriz[i, j] = Math.Abs(matriz[i, j]);
                    }
                }
            }
        }

        
        static void MostrarMatriz(int[,] matriz)
        {
            
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}


