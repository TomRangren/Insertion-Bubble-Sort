using System;
using System.Diagnostics;

namespace Sorting_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            int[] bubble = randomNumbers();
            sw.Start();
            Bubbelsortera(bubble);
            sw.Stop();
            Console.WriteLine(sw.Elapsed.TotalSeconds);
        }
        public static void Bubbelsortera(int[] lista)
        {
            for (int i = lista.Length - 1; i > 0; i--)
            {
                for (int n = 0; n < i; n++)
                {
                    if (lista[n] > lista[n + 1])
                    {
                        int temp = lista[n];
                        lista[n] = lista[n + 1];
                        lista[n + 1] = temp;
                    }
                }
            }
           /* for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }*/
        }
        public static int[] randomNumbers()
        {
            Random random = new Random();
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = random.Next(numbers.Length);
            return numbers;
        }
    }
}
    
 
   
