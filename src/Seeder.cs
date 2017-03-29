using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seeder
{
    public class SeedMachine : ISeedMachine
    {
        public void StartNewSeed(Type type)
        {
            Seeds.Add(new Seed(type));
        }

        private IList<Seed> Seeds { get; set; }

        public SeedMachine() {
            Seeds = new List<Seed>();
        }
    }
}
