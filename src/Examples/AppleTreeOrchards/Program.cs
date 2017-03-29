using AppleTreeOrchards.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Seeder;

namespace AppleTreeOrchards
{
    class Program
    {
        static void Main(string[] args)
        {
            // I want to seed my apples, trees and orchards!

            var seeder = new SeedMachine().Seed<Apple>().Assembly().Resource("AppleTreeOrchards.Seeds.Apple.csv");
        }
    }
}
