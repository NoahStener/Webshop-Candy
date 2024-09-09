namespace Webshop_Candy.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemID { get; set; }
        public string ShoppingCartID { get; set; }
        public Candy Candy { get; set; }
        public int Amount { get; set; }
    }
}
