using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri Musteri1 = new Musteri();
            Musteri1.Id = 5621745;
            Musteri1.Adi = "Güven";
            Musteri1.Soyadi = "Aksüt";
            Musteri1.Yasi = 48;
            Musteri1.DogumYeri = "Balıkesir";
            Musteri1.AnneKizlikSoyadi = "Yavuz";
            Musteri1.Sifre = 55227766;

            Musteri Musteri2 = new Musteri();
            Musteri2.Id = 5765221;
            Musteri2.Adi = "Sevim";
            Musteri2.Soyadi = "Kılıç";
            Musteri2.Yasi = 47;
            Musteri2.DogumYeri = "Aydın";
            Musteri2.AnneKizlikSoyadi = "Satılmış";
            Musteri2.Sifre = 21345112;

            Musteri Musteri3 = new Musteri();
            Musteri3.Id = 7852123;
            Musteri3.Adi = "Duru";
            Musteri3.Soyadi = "Akarsu";
            Musteri3.Yasi = 27;
            Musteri3.DogumYeri = "Sivas";
            Musteri3.AnneKizlikSoyadi = "Peri";
            Musteri3.Sifre = 54621578;

            Musteri Musteri4 = new Musteri();
            Musteri4.Id = 4513211;
            Musteri4.Adi = "Kemal";
            Musteri4.Soyadi = "Parlak";
            Musteri4.Yasi = 25;
            Musteri4.DogumYeri = "Mersin";
            Musteri4.AnneKizlikSoyadi = "Keskin";
            Musteri4.Sifre =  45613351;

            
            Musteri Musteri5 = new Musteri();
            Musteri5.Id = 6633254;
            Musteri5.Adi = "Keriman";
            Musteri5.Soyadi = "Yassıkılıç";
            Musteri5.Yasi = 35;
            Musteri5.DogumYeri = "Erzurum";
            Musteri5.AnneKizlikSoyadi = "Bilgin";
            Musteri5.Sifre = 546451354;

            Musteri Musteri6 = new Musteri();
            Musteri6.Id = 5524111;
            Musteri6.Adi = "Medine";
            Musteri6.Soyadi = "Ateş";
            Musteri6.Yasi = 65;
            Musteri6.DogumYeri = "Karabük";
            Musteri6.AnneKizlikSoyadi = "Kahraman";
            Musteri6.Sifre = 574545135;

            Musteri Musteri7 = new Musteri();
            Musteri7.Id = 7855122;
            Musteri7.Adi = "Ahmet Mümtaz";
            Musteri7.Soyadi = "Osmanoğlu";
            Musteri7.Yasi = 75;
            Musteri7.DogumYeri = "Bursa";
            Musteri7.AnneKizlikSoyadi = "Çetin";
            Musteri7.Sifre = 88522142;

            Musteri[] musteriler = new Musteri[] { Musteri1, Musteri2, Musteri3, Musteri4, Musteri5, Musteri6, Musteri7 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(Musteri1);
            musteriManager.Ekle(Musteri2);
            musteriManager.Ekle(Musteri7);
            musteriManager.Sil(Musteri6);
            musteriManager.Sil(Musteri4);
            musteriManager.Listele(musteriler);
            
           



        }
    }
}