using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteriBilgileri)
        {
            Console.WriteLine(musteriBilgileri.Adi + musteriBilgileri.Soyadi + "Musterisi Başarılı bir şekilde eklendi.");
        }
        public void MusteriGuncelle(Musteri musteriBilgileri)
        {
            Console.WriteLine(musteriBilgileri.Adi + "İsimli Müşterinin " + musteriBilgileri.TcNo + " TC nosuna ait hesabı güncellendi güncel bakiye " + musteriBilgileri.Bakiye);
        }

        public void MusteriSil(Musteri musteriBilgileri)
        {
            Console.WriteLine(musteriBilgileri.TcNo + " Numarasına sahip " + musteriBilgileri.Adi + musteriBilgileri.Soyadi + "Musterisi silindi.");
        }
    }
}
