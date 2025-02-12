using System;

namespace Snatissimo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] matriz = new int[10, 10]; 

            int soma = 0; 

        
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i, j] = rand.Next(1, 101); 
                    soma += matriz[i, j]; 
                }
            }

          
            Console.WriteLine("Valores da diagonal principal:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(matriz[i, i] + " ");
            }

            Console.WriteLine();

            
            int somaDiagonal = 0;
            for (int i = 0; i < 10; i++)
            {
                somaDiagonal += matriz[i, i]; // Somando os elementos da diagonal principal
            }

            // Exibindo a soma total de todos os números da matriz
            Console.WriteLine("Soma total dos valores da matriz: " + soma);
            Console.WriteLine("Soma dos valores da diagonal principal: " + somaDiagonal);

            // Aguardando o pressionamento de uma tecla para continuar
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
