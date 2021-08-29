using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsysnchronousProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hello\n");
            DoSomethingAsync();
            DoSomething2();

            Console.ReadLine();
        }

        public static async Task DoSomethingAsync()
        {
            await Task.Run(() =>
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"Method 1 ={i}");
                }
            });
        }

        public static void DoSomething2()
        {
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine($"Method 2 =={i}");
            }
        }
    }
}
