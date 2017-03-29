using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleTreeOrchards.Models
{
    public class AppleTree
    {
        public AppleTree() { }

        public virtual int ID { get; set; }

        public virtual string Name { get; set; }

        public virtual ISet<Apple> Apples { get; set; }

        public virtual AppleTreeOrchard Orchard { get; set; }
    }
}
