using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class TasitKrediManager : IKrediManager
    {
        public void BasvuruYap()
        {
            Console.WriteLine("Tasit kredisi başvursu yapıldı.");

        }

        public void Hesapla()
        {
            Console.WriteLine("Tasit kredisi hesaplandı.");

        }
    }
}
