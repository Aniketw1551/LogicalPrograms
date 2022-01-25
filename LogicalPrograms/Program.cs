using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LogicalPrograms");

            Program obj = new Program();
            obj.LogicalMethod();
            Console.ReadLine();
        }
        public void LogicalMethod()
        {
            bool CONTINUE = true;
            while (CONTINUE)
            {
                Console.WriteLine("Choose your option");
                Console.WriteLine("1.FibonacciSeries 0.Exit");
                int Choose = int.Parse(Console.ReadLine());
                switch (Choose)
                {
                    case 1:
                        FibonacciSeries.FindFibonacciSeries();
                        break;

                    default:
                        CONTINUE = false;
                        break;
                }
            }
        }
    }
}

