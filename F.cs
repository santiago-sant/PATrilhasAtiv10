using System;

namespace snatissimo
{
    class Program
    {
        public static void Main(string[] args)
        {
        	Random rand = new Random();
        	int [,] matriz = new int[3,3];

        	int soma = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                	matriz[i,j]  = rand.Next(1,101);
                	soma += matriz[i,j];
                }
               
            }
            
            for (int i = 0;i < 3;i++)
            {
            	for (int j = 0;j < 3;j++)
            	{
            		Console.Write(matriz[i,j] + " ");
            	}
            	Console.WriteLine();
            }
            
            int maiorValor = matriz[0,0];
            
            for (int i = 0;i < 3; i++)
            {
            	for (int j = 0;j < 3;j++)
            	{
            		if (matriz[i,j] > maiorValor)
            		{
            			maiorValor = matriz[i,j];
            		}
            			
            	}
            }
            
            Console.WriteLine ("O maior valor é : " + maiorValor);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
