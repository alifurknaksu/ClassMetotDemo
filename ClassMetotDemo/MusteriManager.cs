using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("\n Yeni Müşteri Eklendi: " + musteri.Adi + " " + musteri.Soyadi);

        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("\n Siliniyor : " + musteri.Adi + " " + musteri.Soyadi);
        }
        public void Listele(Musteri[] musteriler)
        {
            Console.WriteLine("\n--------------Musteriler---------------------");
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("\n Müşteri Numarası : " + musteri.Id);
                Console.WriteLine("\n Müşteri Adı : " + musteri.Adi);
                Console.WriteLine("\n Müşteri Soyadı : " + musteri.Soyadi);
                Console.WriteLine("\n Müşteri Yaşı : " + musteri.Yasi);
                Console.WriteLine("\n Müşterinin Şifresi : " + musteri.Sifre);
                Console.WriteLine("\n Müşterinin Doğum Yeri : " + musteri.DogumYeri);
                Console.WriteLine("\n Müşterinin Anne Kızlık Soyadı : " + musteri.AnneKizlikSoyadi);
                Console.WriteLine("\n----------------------------------------------");
            }
        }
    }
}