using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Çalışan Sayısı: {Calisan.CalisanSayisi}");

            Calisan calisan = new Calisan("Burak", "Beştaş", "Yazılım");
            Console.WriteLine($"Çalışan Sayısı: {Calisan.CalisanSayisi}");

            Console.WriteLine($"Toplama İşlemi Sonucu: {Islemler.Topla(15,10)}");
            Console.WriteLine($"Çıkarma İşlemi Sonucu: {Islemler.Cikar(15, 10)}");
        }
    }

    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi; }

        private string Isim;
        private string SoyIsim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyIsim, string departman)
        {
            this.Isim = isim;
            this.SoyIsim = soyIsim;
            this.Departman = departman;
            calisanSayisi++;
        }

    }
    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }

}
