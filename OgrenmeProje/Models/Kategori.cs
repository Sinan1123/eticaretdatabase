using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenmeProje.Models
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Adi {  get; set; }
        public bool IsPassive { get; set; } = false;
        public string Aciklama { get; set; }
        public int KategoriNo {  get; set; }
        public int Sira {  get; set; }
        public DateTime OlusturulmaTarihi { get; set; } = DateTime.Now;
        public ICollection<Urun> Urunler { get; set; } = new List<Urun>();
    }
}
