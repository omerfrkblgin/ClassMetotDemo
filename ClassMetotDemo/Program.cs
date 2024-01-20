using ClassMetotDemo;

class Program
{
    static void Main()
    {
        MusteriManager musteriManager = new MusteriManager();

        Musteri musteri1 = new Musteri(1, "Ömer", "Bilgin", "omer@gmail.com");
        Musteri musteri2 = new Musteri(2, "Hasan", "Tahsin", "hasan@gmail.com");
        Musteri musteri3 = new Musteri(3, "Talat", "Paşa", "talat@gmail.com");
        Musteri musteri4 = new Musteri(4, "Bumin", "Kağan", "bumin@gmail.com");

        musteriManager.MusteriEkle(musteri1);
        musteriManager.MusteriEkle(musteri2);
        musteriManager.MusteriEkle(musteri3);
        musteriManager.MusteriEkle(musteri4);

        musteriManager.MusteriListele();

        musteriManager.MusteriSil(1);

        musteriManager.MusteriListele();
    }
}