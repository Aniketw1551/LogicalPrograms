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
                Console.WriteLine("1.FibonacciSeries 2.Perfect Number 3.Prime Number 0.Exit");
                int Choose = int.Parse(Console.ReadLine());
                switch (Choose)
                {
                        case 1:
                        FibonacciSeries.FindFibonacciSeries();
                        break;
                        case 2:
                        PerfectNumber.FindPerfectNumber();
                        break;
                       case 3:
                       PrimeNumber.TakingInput();
                        break;
                       case 0:
                        break;

                    default:
                        CONTINUE = false;
                        break;
                }
            }
        }
    }
}

