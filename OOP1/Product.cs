using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    //ürünün özellikleri olur
    //bu tür classlarda sadece özellikler olur buna dikkat!!!
    //Entity'de deniyor.
    internal class Product
    {
        //encapsulation işlemi yapmış oluyoruz aslında bir sınıf içinde özellikleri toplamış oluyoruz
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
}
