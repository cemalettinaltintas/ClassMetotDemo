using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        List<Musteri> musteriler=new List<Musteri> ();
        public MusteriManager()
        {
            
        }
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad+" isimli müşteri eklendi!" );
            musteriler.Add(musteri);
        }
        public List<Musteri> Listele()
        {
            return musteriler;
            //foreach (var musteri in this.musteriler)
            //{
            //    Console.WriteLine("Müşteri Adı : " + musteri.Ad);
            //    Console.WriteLine("Müşteri Soyadı : " + musteri.Soyad);
            //    Console.WriteLine("Müşteri Maaşı : " + musteri.Maas);
            //    Console.WriteLine("-------------------------------");
            //}
        }
        public void Sil(Musteri musteri)
        {
            musteriler.Remove(musteri);
            Console.WriteLine(musteri.Ad + " isimli müşteri silindi!");
        }
    }
}
