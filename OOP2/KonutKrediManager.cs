using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class KonutKrediManager : IKrediManager
    {
        public void BasvuruYap()
        {
            Console.WriteLine("Konut kredisi için basvuru yap.");
        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi hesaplandı.");
        }
    }
}
