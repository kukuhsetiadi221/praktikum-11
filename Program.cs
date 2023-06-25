using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Printer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Printer Epson = new Epson();
            Printer Canon = new Canon();
            Printer LasetJet = new LasetJet();

            Epson.merek = "Epson";
            Epson.dimension = "10*11";

            Canon.merek = "Canon";
            Canon.dimension = "9.5*12";

            LasetJet.merek = "LasetJet";
            LasetJet.dimension = "12*12";

            Console.WriteLine("Pilih printer:");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LasetJet");
            Console.WriteLine();
            Console.Write("Nomor printer [1..3]: ");

            int pilih = Convert.ToInt32(Console.ReadLine());

            //pengkondisian
            if (pilih==1)
            {
                Epson.Print();
            }
            else if (pilih==2)
            {
                Canon.Print();
            }
            else if (pilih==3)
            {
                LasetJet.Print();
            }
            else
            {
                Console.WriteLine("Tipe printer yang kamu pilih {0} tidak pada daftar printer");

            }
            Console.ReadKey();
        }
    }
}
