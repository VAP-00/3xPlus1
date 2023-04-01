using System;
using System.Numerics;

class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        private static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3x + 1");
            Console.ResetColor();
            Console.WriteLine("Give any number where x > 1");
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            if(b < 1)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Give a bigger number!! hint: x > 1");
                Console.ResetColor();
                Restart();
            }
            BigInteger count = new BigInteger(0);
            while (true)
            {
                if (b == 1)
                    break;
                else
                    count++;
                b = Calc(b);
            }
            Console.WriteLine("It took " + count + " iterations to get to 1");
            Restart();
        }
        private static BigInteger Calc(BigInteger a)
        {
            if(a % 2 != 0)
            {
                return a * 3 + 1;
            }
            else if(a % 2 == 0)
            {
                return a / 2;
            }
            return 0;
        }
        private static void Restart()
        {
            Console.ReadKey();
            Console.Clear();
            Start();
        }
    }