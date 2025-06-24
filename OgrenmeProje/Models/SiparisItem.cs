using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenmeProje.Models
{
    public class SiparisItem
    {
        public int Id { get; set; }
        public double BirimFiyat { get; set; }
        public int Adet {  get; set; }
        public int SiparisId { get; set; }
        [ForeignKey ("SiparisId")]
        public Siparis Siparis { get; set; }
        public int UrunId { get; set; }
        [ForeignKey ("UrunId")]
        public Urun Urun { get; set; }
        public double AraToplam { get; set; }
    }
}
