using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.ID = 1010;
            musteri1.Ad = "Engin";
            musteri1.Soyad = "Demirog";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 1020;
            musteri2.Ad = "Beytullah";
            musteri2.Soyad = "GÖKOĞLAN";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Add(musteri1);
            musteriManager.Add(musteri2);
            musteriManager.Listeleme(musteriler);
            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri2);
            //Console.WriteLine("Hello World!");
        }
    }
}
