using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class MusteriManager
    {
        private List<Musteri> musteriler;

        public MusteriManager()
        {
            musteriler = new List<Musteri>();
        }

        public void MusteriEkle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine($"{musteri.Ad} {musteri.Soyad} adlı müşteri eklendi.");
        }

        public void MusteriListele()
        {
            Console.WriteLine("Müşteri Listesi:");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine($"ID: {musteri.Id} | Ad: {musteri.Ad} | Soyad: {musteri.Soyad}");
            }
        }

        public void MusteriSil(int id)
        {
            Musteri silinecekMusteri = musteriler.Find(m => m.Id == id);

            if (silinecekMusteri != null)
            {
                musteriler.Remove(silinecekMusteri);
                Console.WriteLine($"{silinecekMusteri.Ad} {silinecekMusteri.Soyad} adlı müşteri silindi.");
            }
            else
            {
                Console.WriteLine("Belirtilen ID'ye sahip müşteri bulunamadı.");
            }
        }

    }
}
