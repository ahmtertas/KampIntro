using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class IhtiyacKrediManager : IKrediManager
    {
        public void BasvuruYap()
        {
            Console.WriteLine("İhtiyac kredisi başvursu yapıldı.");
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyac kredisi hesaplandı.");
        }
    }
}
