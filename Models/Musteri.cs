using System.ComponentModel.DataAnnotations;

namespace Muhasebe.Models
{
    public class Musteri
    {
        [Key]
        public int id { get; set; }
        public string ad { get; set; }
        public string soyAd { get; set; }
        public string adres { get; set; }
        public string aldigiUrun { get; set; }

    }
}
