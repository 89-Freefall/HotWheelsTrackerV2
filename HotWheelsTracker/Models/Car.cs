using System.ComponentModel.DataAnnotations;

namespace HotWheelsTracker.Models
{
    public class Car
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Series { get; set; }

        [Range(1950, 2050)]
        public int Year { get; set; }

        [StringLength(30)]
        public string Color { get; set; }

        [StringLength(20)]
        public string Condition { get; set; }

        [Range(0, 10000)]
        public decimal Value { get; set; }
    }
}