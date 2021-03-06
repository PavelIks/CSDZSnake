using System;
using System.Linq;

namespace dzshka
{
    struct Snake
    {
        public string numb_N;
        public string numb_M;

        public void DisplayInfo()
        {
            Console.WriteLine($"N:{numb_N} | M:{numb_M}\n");
            if (numb_N.All(char.IsDigit) && numb_M.All(char.IsDigit))
            {
                int a = Int32.Parse(numb_N);
                int b = Int32.Parse(numb_M);

                for (int i = 1; i <= (a * b); i++)
                {
                    Console.Write("▬");
                }
            }
            else
            {
                Console.WriteLine("В строке должны быть int-числа!");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Snake snake;
            Console.Write("Введите N (кол. раз): ");
            snake.numb_N = Console.ReadLine();
            Console.Write("Введите M (длину): ");
            snake.numb_M = Console.ReadLine();
            snake.DisplayInfo();
            Console.ReadKey();
        }
    }
}