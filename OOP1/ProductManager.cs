using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //ürünle ilgili operasyonlar
    internal class ProductManager
    {
        //ürünle ilgili operasyonlar
        //ekleme,silme,güncelleme,listeleme,arama şeklinde içerir.

        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");

        }     



    }
}
