using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenecirsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();

            isimler.Add("Ahmet");
            Console.WriteLine(isimler.Length);
            isimler.Add("Ayşe");
            isimler.Add("Fatma");
            isimler.Add("Huriye");
            Console.WriteLine(isimler.Length);
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
