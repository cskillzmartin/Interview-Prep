using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Interview_Prep.Controllers
{
    public class ProjectEulerController : Controller
    {
        public ActionResult Index()
        {
            int SUM = 0;
            for (int i = 3; i < 1000; i++)
            {
                if (i % 3 == 0 && i % 5 != 0)
                    SUM += i;

                if (i % 3 != 0 && i % 5 == 0)
                    SUM += i;

                if (i % 3 == 0 && i % 5 == 0)
                    SUM += i;
            }

            return View(SUM);
        }


        public ActionResult FibonacciEvenSum()
        {
            int first = 0;
            int second = 1;
            int evenSum = 0;


            for (int i = 1; i < 100000; i++)
            {
                int newSum = first + second;
                if (newSum > 4000000)
                    break;
                if (newSum % 2 == 0)
                    evenSum += newSum;

                first = second;
                second = newSum;
            }

            return View(evenSum);
        }

        public ActionResult PrimeFactors()
        {
            var factors = new ConcurrentDictionary<long, bool>();
            var number = 600851475143;

            Parallel.For(3, number, new ParallelOptions() { MaxDegreeOfParallelism = Environment.ProcessorCount }, i =>
            {
                if (number % i == 0)
                    if (isPrime(i))
                        factors.TryAdd(i, true);
            });

            return View(factors);
        }

        public bool isPrime(long factor)
        {
            var isPrime = true;
            for (long i = 3; i < factor; i += 2)
            {
                if (factor % i == 0)
                {
                    isPrime = false;
                    break;
                }

            }

            return isPrime;
        }
    }
}