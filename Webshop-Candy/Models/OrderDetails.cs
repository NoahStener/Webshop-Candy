using System.ComponentModel.DataAnnotations;

namespace Webshop_Candy.Models
{
    public class OrderDetails
    {
        [Key]
        public int OrderDetailsID { get; set; }
        public int OrderID { get; set; }
        public Order Order { get; set; }
        public int CandyID { get; set; }
        public Candy Candy { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

    }
}
