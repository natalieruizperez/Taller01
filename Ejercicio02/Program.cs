namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            float[] lista = CrearLista();
    
            MostrarLista(lista);

            CalcularPositivos(lista); 
        }

        
        static float[] CrearLista()
        {
            Console.WriteLine("Ingrese la cantidad de elementos de la lista:");
            int cantidad = Convert.ToInt32(Console.ReadLine());

            float[] lista = new float[cantidad];

            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine($"Ingrese el elemento [{i + 1}] de la lista:");
                lista[i] = Convert.ToSingle(Console.ReadLine());
            }
            return lista;
        }

        
        static void MostrarLista(float[] lista)
        {
            Console.WriteLine("\nLos números de la lista son:");
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {lista[i]}");
            }
        }

        
        static void CalcularPositivos(float[] lista)
        {
            float suma = 0;
            int contador = 0;

            foreach (float numero in lista)
            {
                if (numero > 0)
                {
                    suma += numero;
                    contador++;
                }
            }

            if (contador > 0)
            {
                float promedio = suma / contador;
                Console.WriteLine($"\nLa suma de números positivos es: {suma}");
                Console.WriteLine($"El promedio de números positivos es: {promedio}");
            }
            else
            {
                Console.WriteLine("\nNo hay números positivos en la lista.");
            }
        }
    }
}
    

