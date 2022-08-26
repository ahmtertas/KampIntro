using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenecirsIntro
{
    internal class MyList<T>
    {
        //items isminde T türünde bir dizi tanımladık
        T[] _items;
        T[] _tempArray;
        public MyList()
        {
            //conts. ile 0 elemanlı t türünde referans aldık
            _items = new T[0];
        }

        public void Add(T item)
        {
            //tempArray--> geçiciDizi, itemsin elemanları newleme esnasında gideceği için,
            //temparray'e elemanlarını tutturuyoruz.
            _tempArray = _items;
            //ekleme esnasında mevcut eleman sayısı +1 şeklinde devam edecek.
            _items = new T[_items.Length+1];
            //sana verdiğim elemanları bana geri versene diyoruz
            for (int i = 0; i < _tempArray.Length; i++)
            {
                //tempArray'in 0. elemanı eşittir itemsin 0. elemanı
                _items[i] = _tempArray[i];
            }

            //ekleme operasyonundan gelen item elemanı şimdi daha yeni ekleniyor dizimize!!!!
            //items'ın eleman sayısının 1 eksiği, itemsdeki dizi eleman sayısının son indeks numarasıdır.
            _items[_items.Length - 1] = item;

        }

        public int Length
        {
            get { return _items.Length; }
        }
        public T[] Items
        {
            get { return _items; }
        }
    }
}
