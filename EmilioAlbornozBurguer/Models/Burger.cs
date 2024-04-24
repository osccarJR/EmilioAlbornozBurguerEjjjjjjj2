using System.ComponentModel.DataAnnotations;

namespace EmilioAlbornozBurguer.Models
{
    public class Burger
    {
        [Key]
        public int BurgerId { get; set; }

        [Required]
        public string? Name { get; set; }
        public bool WithCheese { get; set; }

        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }

        public List<Promo>? Promo { get; set; }
    }
}
