using System.ComponentModel.DataAnnotations;

namespace Webshop_Candy.Models
{
    public class Candy
    {
        [Key]
        public int CandyID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsOnSale { get; set; }
        public bool IsInStock { get; set; }
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
