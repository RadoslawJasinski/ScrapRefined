namespace ScrapRefined.Models
{
    public class UserFavouriteProduct
    {
        public int Id { get; set; }
        public DateTime AddedTime { get; set; }
        public User User { get; set; }
        public Product Product { get; set; }
    }
}
