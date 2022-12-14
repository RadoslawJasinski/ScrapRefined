using System.ComponentModel;

namespace ScrapRefined.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public User AddedBy { get; set; }
        public bool IsSold { get; set; }
        public string Description { get; set; }
        //public List<Tag> Tags { get; set; }
        public Category Category { get; set; }
        public string CoverURL { get; set; }
        public List<ProductImage> Images { get; set; }
    }
}