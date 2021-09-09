using System;
using System.Linq;

namespace dzshka
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите N (кол. раз): ");
            string numb_N = Console.ReadLine();
            Console.Write("Введите M (длину): ");
            string numb_M = Console.ReadLine();
            if (numb_N.All(char.IsDigit) && numb_M.All(char.IsDigit))
            {
                int x = Int32.Parse(numb_N);
                int y = Int32.Parse(numb_M);

                for (int i = 1; i <= (x * y); i++)
                {
                    Console.WriteLine("█\n");
                }
            }
            else
            {
                Console.WriteLine("Стока должна быть только intовой...");
            }

            // Без проверки на число
            /*Console.Write("Введите N (кол. раз): ");
            int numb_N = Int32.Parse(Console.ReadLine());
            Console.Write("Введите M (длину): ");
            int numb_M = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= (numb_M * numb_N); i++)
            {
                Console.WriteLine("█\n");
            }*/
        }
    }
}