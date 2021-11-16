using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Cemalettin";
            musteri1.Soyad = "Altıntaş";
            musteri1.Maas = 5000;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Oğuz";
            musteri2.Soyad = "Altıntaş";
            musteri2.Maas = 6000;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };



            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            foreach (var musteri in musteriManager.Listele())
            {
                Console.WriteLine(musteri.Ad);
            }
            
            musteriManager.Sil(musteri1);
        }

    }
}
