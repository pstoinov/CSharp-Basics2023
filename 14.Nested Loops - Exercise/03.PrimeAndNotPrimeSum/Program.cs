﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sums_prime_and_non_prime_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int primeSum = 0, notPrimeSum = 0;
            while (input != "stop")
            {
                int number = int.Parse(input);
                if (number <0)
                {
                    Console.WriteLine("Number is negative.");
                }
                else
                {
                    bool isPrime = true;
                    double sqrt = Math.Sqrt(number);
                    for (int i = 2; i <= sqrt && isPrime; i++)
                    {
                        if (number % i == 0)
                        {
                            isPrime = false;
                        }
                    }
                    if (isPrime)
                    {
                        primeSum += number;
                    }
                    else
                    {
                        notPrimeSum += number;
                    }
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {notPrimeSum}");








            ////string input = string.Empty;
            //string input = Console.ReadLine();

            //int sumprime = 0;
            //int sumnoprime = 0;

            //while (input != "stop")
            //{
            //    bool isprime = true; // направих променливата ти true.
            //    int n = int.Parse(input);
            //    if (n < 0)
            //    {
            //        n = 0;
            //        Console.WriteLine("Number is negative.");

            //    }

            //    else if (n == 1)
            //    {
            //        isprime = false;
            //    }
            //    else
            //    {
            //        for (int count = 2; count <= n; count++)
            //        {
            //            if (n % count == 0 && count != n)

            //            {
            //                isprime = false;

            //                break;
            //            }
            //        }

            //    }
            //    if (isprime)
            //    {
            //        sumprime += n;
            //    }
            //    else if (isprime == false)
            //    {
            //        sumnoprime += n;
            //    }
            //    input = Console.ReadLine();
            //}
            //if (input == "stop")
            //{
            //    Console.WriteLine($"Sum of all prime numbers is: {sumprime}");
            //    Console.WriteLine($"Sum of all non prime numbers is: {sumnoprime}");
            //}
        }
    }
}