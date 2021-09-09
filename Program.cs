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
                int x = Int32.Parse(numb_N);
                int y = Int32.Parse(numb_M);

                for (int i = 1; i <= (x * y); i++)
                {
                    Console.WriteLine("█\n");
                }
            }
            else
            {
                Console.WriteLine("Строка должна быть только intовой...");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Snake snake;
            snake.numb_N = "1";
            snake.numb_M = "5";
            snake.DisplayInfo();

            Console.ReadKey();
        }
    }
}