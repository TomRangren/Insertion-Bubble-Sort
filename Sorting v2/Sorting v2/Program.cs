using System;
using System.Diagnostics;

namespace BubbleSort
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
            Console.WriteLine(sw.Elapsed.TotalSeconds+" Sekunder tog det!");
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
            for (int i = 0; i < lista.Length; i++)
            {
                Console.WriteLine(lista[i]);
            }
        }
        public static int[] randomNumbers()
        {
            Random random = new Random();
            int[] numbers = new int[100000];
            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = random.Next(numbers.Length);
            return numbers;
        }
        public static void Insertion(int[] lista)
        {
            int a, m;
            int length = lista.Length; if (length < 2) return;
            int temp;

            for (m = 1; m < length; m++)
            {
                temp = lista[m];
                a = m - 1;

                while (a >= 0 && lista[a] > temp)

                {
                    lista[a + 1] = lista[a];
                    a--;
                }
                lista[a + 1] = temp;
            }
        }
    }
}




