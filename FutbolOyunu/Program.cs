using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolOyunu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Futbol> takim = new List<Futbol>();
            takim.Add(new Futbol("Kaleci", 1));
            takim.Add(new Defans("defans1", 2));
            takim.Add(new Defans("defans2", 3));
            takim.Add(new Defans("defans3", 4));
            takim.Add(new Defans("defans4", 5));
            takim.Add(new OrtaSaha("Ortasaha1", 6));
            takim.Add(new OrtaSaha("Ortasaha2", 7));
            takim.Add(new OrtaSaha("Ortasaha3", 8));
            takim.Add(new OrtaSaha("Ortasaha3", 9));
            takim.Add(new Forvet("Forvet1", 10));
            takim.Add(new Forvet("Forvet2", 11));
            Random Rastgele = new Random();
            int FormaNo;
            int PasKontrol = 12;
            Boolean gololabilir = true;
            FormaNo = Rastgele.Next(1, 12);
            for (int i = 1; i <= 3; i++)
            {
                while (PasKontrol == FormaNo)
                {
                    FormaNo = Rastgele.Next(1, 12);
                }
                PasKontrol = FormaNo;
                if (!takim([FormaNo - 1].Pasver())
                {
                    Console.WriteLine(FormaNo+" Numaralı Oyuncunun Pası Başarısız.");
                    gololabilir = false;
                    break;
                }
                else
                {
                    Console.WriteLine(FormaNo + " Numaralı Oyuncunun Pası Tam İsabet.");
                    System.Threading.Thread.Sleep(1000);
                }
            }
            Console.WriteLine(FormaNo + " Numaralı Oyuncu Kaleci ile Karşı Karşıya!");
            System.Threading.Thread.Sleep(1000);
            if (gololabilir = true)
            {
                if (!takim[FormaNo - 1].Golvurusu()
                {
                    Console.WriteLine(" Az Farkla Kaçırdı.");
                }
                else
                {
                    Console.WriteLine(" GOOOOOOOOLLLLLLLLLLLLLL !..");
                }
            }
            Console.ReadLine();
        }
    }
}
