using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public class Canon : Printer
    {
        public override void Print()
        {
            Console.WriteLine("{0} display dimension : {1}", merek, dimension);
            Console.WriteLine("{0} printer printing..", merek);
        }
    }
}
