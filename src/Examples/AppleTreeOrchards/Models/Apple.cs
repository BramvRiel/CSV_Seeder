using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleTreeOrchards.Models
{
    public class Apple
    {
        public Apple() { }

        public virtual int ID { get; protected set; }

        public virtual string Color { get; set; }

        public virtual AppleTree Tree { get; set; }
    }
}
