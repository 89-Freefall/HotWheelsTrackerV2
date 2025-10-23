using System.ComponentModel.DataAnnotations;

namespace HotWheelsTracker.Models
{
    public class Car
    {
        public int Id { get; set; } // Primary key

        [Required]
        public string Name { get; set; }

        public string Series { get; set; }

        [Range(1950, 2100)]
        public int Year { get; set; }

        public string Color { get; set; }

        public string Condition { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Value { get; set; }
    }
}