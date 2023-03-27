using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _036.hatvanyertek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kérem a hatvány alapot! ");
            int alap = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kérem a hatvány kitevőt! ");
            int kitevo = Convert.ToInt32(Console.ReadLine());

            double pow_ab = Math.Pow(alap, kitevo);

            Console.WriteLine("A hatványérték: " + pow_ab);

            Console.ReadLine();
        }
    }
}
