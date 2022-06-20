using System.ComponentModel.DataAnnotations;

namespace Muhasebe.Models
{
    public class Stok
    {
        [Key]
        public int id { get; set; }
        public string urunAd { get; set; }
        public int urunAdet { get; set; }
        public string urunMarka { get; set; }
        public string uretimYeri { get; set; }
        public string urunAciklama { get; set; }
    }
}
