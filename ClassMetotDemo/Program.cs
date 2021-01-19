using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            musteri.Id = 1;
            musteri.Adi = "Hakan";
            musteri.Soyadi = "Sonmez";
            musteri.TcNo = "123456789012";
            musteri.TelefonNumarasi = "5301114433";
            musteri.Bakiye = 187;

            Musteri musteriGuncelle = new Musteri();

            musteriGuncelle.Id = 1;
            musteriGuncelle.Bakiye = 300;

            Musteri musteriSil = new Musteri();
            musteriSil.Id = 1;

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri);
            musteriManager.MusteriGuncelle(musteriGuncelle);
            musteriManager.MusteriSil(musteriSil);



        }
    }
}
