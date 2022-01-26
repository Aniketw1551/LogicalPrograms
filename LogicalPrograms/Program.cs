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
                Console.WriteLine("1.FibonacciSeries 2.Perfect Number 3.Prime Number 4.Reverse Number");
                Console.WriteLine("5.CouponNumber 6.StopWatch 0.Exit");
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
                        case 4:
                        ReverseNumber.GetRevNumber();
                        break;
                        case 5:
                        CouponNumbers couponNumbers = new CouponNumbers();
                        int count = couponNumbers.GenerateDistinctCoupon();
                        Console.WriteLine("No of Distinct Coupons Generated: " + count);
                        break;
                        case 6:
                        StopWatch.GetElapsedTime();
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

