﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenmeProje.Models
{
    public class Siparis
    { 
        public int Id { get; set; }
        public int SiparisNo { get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public int KullaniciId { get; set; }

        [ForeignKey("KullaniciId")]
        public Kullanici Kullanici { get; set; }
        public double Toplam {  get; set; }
        public ICollection<SiparisItem> SiparisItemler { get; set; }

    }
}
