using System.ComponentModel.DataAnnotations;

namespace HealthRX.Models.DTOs
{
    public class ProductDTO
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int CategoryID { get; set; }

        public decimal Price { get; set; }

        public string Manufacturer { get; set; }

        public DateTime ManufactureDate { get; set; }

        public DateTime ExpiryDate { get; set; }

        public string PictureLink { get; set; }


    }
}
