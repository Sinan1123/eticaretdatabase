using OgrenmeProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OgrenmeProje.Data
{
    public class DbHelper
    {
        AppDbContext _db = new AppDbContext();

        public string KullaniciEkle(Kullanici data)
        {
            data.Sifre = Auth.Hash(data.Sifre); 
            _db.Kullanicilar.Add(data);
            _db.SaveChanges();
            return $"Kullanıcı eklendi";
        }
        public string KategoriEkle (Kategori data)
        {
            _db.Kategori.Add(data);
            _db.SaveChanges();
            return $"Kategori Eklendi";
        }

        public string Urunekle (Urun data)
        {
            _db.Urunler.Add(data);
            _db.SaveChanges();
            return $"Ürün Eklendi";
        }

        public string SiparisEkle(Siparis data)
        {
            _db.Siparisler.Add(data);
            _db.SaveChanges();
            return $"Siparis var";
        }

        public string SiparisItemEkle(SiparisItem data)
        {
            _db.Siparisitemler.Add(data);
            _db.SaveChanges();
            return $"Siparisitem eklendi";

        }

        public string SifreGuncelle(int kullaniciId, string mevcutSifre, string yeniSifre)
        {
            Kullanici data = _db.Kullanicilar.Find(kullaniciId);
            if (data.Sifre != Auth.Hash(mevcutSifre))
                return "Mevcut şifreniz girdiğiniz şifre ile uyuşmuyor";
            else
            {
                data.Sifre = Auth.Hash(yeniSifre);
                _db.SaveChanges();
                return "Şifreniz başarı ile güncellendi";
            }
        }
        public string SifreyiUnuttum (int kullaniciId, string yeniSifre)
        {
            Kullanici data = _db.Kullanicilar.Find(kullaniciId);
            data.Sifre = Auth.Hash(yeniSifre);
            _db.SaveChanges();
            return "Sifreniz başarıyla güncellendi";
        }
    }
}
