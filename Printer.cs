using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public abstract class Printer
    {
        public string merek { get; set; }
        public string dimension { get; set; }
        public abstract void Print();
    }
}