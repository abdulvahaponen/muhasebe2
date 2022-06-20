using System.ComponentModel.DataAnnotations;

namespace Muhasebe.Models
{
    public class Fatura
    {
        [Key]
        public int id { get; set; }
        public string sirket { get; set; }
        public float tutar { get; set; }
        public string adres { get; set; }
        public string ad { get; set; }
        public float faturaNo { get; set; }
    }
}
