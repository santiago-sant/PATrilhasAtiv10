using System;

namespace snatissimo
{
    class Program
    {
        public static void Main(string[] args)
        {
           
            decimal[,] matriz =  {
                {1.2m, 2.3m},
                {11.2m, 12.3m}
            };

          
            Console.WriteLine("Valores da matriz:");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matriz[i, j] + " "); 
                }
                Console.WriteLine(); 
            }

            Console.WriteLine();

            decimal somaTotal = 0;
            
            Console.WriteLine("Média dos valores da matriz (dividido por 4):");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                 somaTotal += matriz[i, j]; 
                  
					
                }
                Console.WriteLine();
            }
            decimal media = somaTotal / 4;
             Console.WriteLine(media + " ");
           

           
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
