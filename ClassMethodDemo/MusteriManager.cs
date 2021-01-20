using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class MusteriManager
    {
        public void Add(Musteri musteri)
        {
            Console.WriteLine("Musteri eklendi!  "+ musteri.Ad);
        }
        public void Delete(Musteri musteri)
        {
            Console.WriteLine("Musteri silindi!  " + musteri.Ad);
        }
        public void Listeleme(Musteri[] musteri)
        {
            foreach (Musteri mus in musteri)
            {
                Console.WriteLine("Musteri ID  "+ mus.ID);
                Console.WriteLine("Musteri Adı  " + mus.Ad);
                Console.WriteLine("Musteri Soyadı  "+ mus.Soyad);
            }
        }
    }
}
