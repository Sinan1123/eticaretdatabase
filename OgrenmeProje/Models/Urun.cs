using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenmeProje.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Fiyat { get; set; }
        public bool IsPassive { get; set; } = false;
        public int Stok {  get; set; }
        public string BarkodNo { get; set; }
        public int KategoriId { get; set; }
        [ForeignKey ("KategoriId")]

        public Kategori UrunKategori { get; set; }
        public ICollection<SiparisItem> SiparisItemler { get; set; }
    }
}
