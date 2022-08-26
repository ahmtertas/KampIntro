using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();


            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService filebaseLoggerService = new FileLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager,
                new List<ILoggerService> 
                { new DatabaseLoggerService(),
                    new FileLoggerService() 
                });
             

            Console.WriteLine("----------------------------");
            //liste oluşturduk IKredManager'ın listesi
            List<IKrediManager> krediManagers = new List<IKrediManager>()
            {
                new IhtiyacKrediManager(),
                new TasitKrediManager(),
                new TasitKrediManager()

            };
            //Listedeki tüm kredi türlerini istediğimiz veri için hesaplamaya çalıştık.
            //basvuruManager.KrediOnBigilendirmesiYap(krediManagers);
            
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
