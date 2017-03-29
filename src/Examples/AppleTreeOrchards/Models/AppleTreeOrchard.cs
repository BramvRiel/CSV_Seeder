using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleTreeOrchards.Models
{
    public class AppleTreeOrchard
    {
        public AppleTreeOrchard() { }

        public virtual int ID { get; set; }

        public virtual string Country { get; set; }

        public virtual ISet<AppleTree> Trees { get; set; }
    }
}
