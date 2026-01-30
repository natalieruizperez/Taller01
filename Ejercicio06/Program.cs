namespace Taller01_Ejercicio06
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Ingrese la cantidad de números impares");
            int total = Convert.ToInt32(Console.ReadLine());

            int suma = CalcularSuma(total);

            Console.WriteLine($"\n La suma es: {suma}");

            static int CalcularSuma(int total)
            {
                int contador = 0;
                int suma = 0;
                int impares = 1;

                if (total <= 0) return 0;

                do
                {
                    Console.WriteLine($"Número impar [{contador + 1}]: {impares}");

                    suma += impares;
                    impares += 2; 
                    contador++; 

                } while (contador < total);

                return suma;
            }
        }     
    }
}
