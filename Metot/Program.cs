// See https://aka.ms/new-console-template for more information
using Metot;

Console.WriteLine("Hello, World!");
SepetManager sepetManager = new SepetManager();
Urun urun = new Urun();
urun.Adi = "Karpuz";
urun.Aciklama = "Diyarbakır Karpuzu";
urun.Fiyati = 25;

sepetManager.Ekle(urun);


Console.ReadLine();