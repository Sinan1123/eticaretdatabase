using OgrenmeProje.Data;
using OgrenmeProje.Models;

namespace OgrenmeProje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbHelper dbHelper = new DbHelper();

            var yeniKullanici = new Kullanici
            {
                AdSoyad = "Ali Yılmaz",
                Email = "ali@example.com",
                Sifre = "12345"
            };

            string sonuc = dbHelper.KullaniciEkle(yeniKullanici);
            Console.WriteLine(sonuc);
            var yeniKategori = new Kategori
            {
                Adi = "sa",
                Aciklama = "12345",
                KategoriNo = 1,
                Sira = 2,
            };
            string sonuc2 = dbHelper.KategoriEkle(yeniKategori);
            Console.WriteLine(sonuc2);

            var yeniKategori2 = new Kategori
            {
                Adi = "Elektronik",
                Aciklama = "Elektronik ürünler",
                KategoriNo = 1,
                Sira = 1,
            };
            Console.WriteLine(dbHelper.KategoriEkle(yeniKategori2));

            var urun = new Urun
            {
                Adi = "Kulaklık",
                Fiyat = "199.99",
                Stok = 50,
                BarkodNo = "KULAK123",
                KategoriId = 1 
            };
            Console.WriteLine(dbHelper.Urunekle(urun));

            var yeniSiparis = new Siparis
            {
                SiparisNo = 101,
                KullaniciId = 1,
                Toplam = 0 
            };
            Console.WriteLine(dbHelper.SiparisEkle(yeniSiparis));

            int adet = 2;
            var siparisItem = new SiparisItem
            {
                SiparisId = 1,
                UrunId = 1,
                BirimFiyat = 199.99,
                Adet = adet,
                AraToplam = adet * 199.99
            };
            Console.WriteLine(dbHelper.SiparisItemEkle(siparisItem));

            int kullaniciId = 1;
            string mevcutSifre = "12345";
            string yeniSifre = "54321";

            string sonuc3 = dbHelper.SifreGuncelle(kullaniciId, mevcutSifre, yeniSifre);
            Console.WriteLine(sonuc3);
        }
    }
}
