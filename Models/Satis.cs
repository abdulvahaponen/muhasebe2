using System.ComponentModel.DataAnnotations;

namespace Muhasebe.Models
{
    public class Satis
    {
        [Key]
        public int id { get; set; }
        public string urun { get; set; }
        public string urunAd { get; set; }
        public string satilanKisi { get; set; }
        public string adres { get; set; }
        public float tutar { get; set; }

    }
}
