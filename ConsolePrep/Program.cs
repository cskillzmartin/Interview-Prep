using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CsvHelper;
using System.IO;
using System.Net.Http;
using System.Web;
using Newtonsoft.Json;
using ContentPal.App.Data;
using ContentPal.App.Models;
using System.Net.Http.Headers;

namespace ConsolePrep
{
    class Program
    {
        static void Main(string[] args)
        {
            var rn = new RomanNumeral().RomanToInt("MCMXCIV");
            Console.WriteLine($"Roman numeral MCMXCIV is {rn} in integer form.");

            Console.ReadKey();
        }
    }
}

