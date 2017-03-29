using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seeder
{
    public interface ISeedMachine
    {
        void StartNewSeed(Type type);
    }
}
