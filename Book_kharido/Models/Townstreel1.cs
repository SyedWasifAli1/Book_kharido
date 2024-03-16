using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Book_kharido.Models
{
    public class Townstreel1
    {
        [Key]
        public int TownsId { get; set; }

        [Required]
        public string? TownName { get; set; }
        public double KoloMeter { get; set; }

        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City? City { get; set; }
        public int CountryId { get; set; }
        [ForeignKey("CountryId")]
        public Country? Country { get; set; }

    }
}
