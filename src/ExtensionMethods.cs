using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seeder
{
    public static class ExtensionMethods
    {
        public static ISeedMachine Seed<T>(this ISeedMachine seeder)
        {
            seeder.StartNewSeed(typeof(T));
            return seeder;
        }

        public static ISeedMachine Assembly(this ISeedMachine seeder)
        {
            return seeder;
        }

        public static ISeedMachine Resource(this ISeedMachine seeder, string resourceCsv)
        {
            return seeder;
        }
    }
}
