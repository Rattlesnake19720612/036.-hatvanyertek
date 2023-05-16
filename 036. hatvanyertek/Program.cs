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

/*Ez a C# nyelven írt program kiszámítja a megadott számot hatványozva. Az alap és a kitevő értékét a felhasználó adja meg a konzolról olvasott bemenetekkel. A Math.Pow() függvény segítségével számítjuk ki a hatványértéket, amelyet egy double típusú változóban tárolunk. Végül kiírjuk a hatvány értékét a konzolra.*/
