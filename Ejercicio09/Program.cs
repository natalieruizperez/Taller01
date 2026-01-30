namespace Ejercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una frase de mínimo 3 palabras:");
            string frase = Console.ReadLine();

            Console.WriteLine("La frase corregida es:");
            string resultado = FraseCorregida(frase);
            Console.WriteLine(resultado);
        }

        private static string FraseCorregida(string texto)
        {

            string[] palabras = texto.Split(' ', StringSplitOptions.RemoveEmptyEntries);


            if (palabras.Length < 3)
            {
                return "Error: La frase debe tener al menos 3 palabras.";
            }

            string resultadoAcumulado = "";

            for (int i = 0; i < palabras.Length; i++)
            {
                
                string palabraMin = palabras[i].ToLower();

                
                char primeraChar = char.ToUpper(palabraMin[0]);

                string nuevaPalabra;

                if (palabraMin.Length > 1)
                {
                    
                    string resto = palabraMin.Substring(1);

                    nuevaPalabra = primeraChar + resto;
                }
                else
                {
                    nuevaPalabra = primeraChar.ToString();
                }

                
                resultadoAcumulado += nuevaPalabra;

                if (i < palabras.Length - 1)
                {
                    resultadoAcumulado += " ";
                }
            }

            return resultadoAcumulado;
        }
    }
    
}
