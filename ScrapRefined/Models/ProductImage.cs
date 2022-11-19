using System.ComponentModel.DataAnnotations;

namespace ScrapRefined.Models
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [StringLength(256)]
        public string ImageURL { get; set; } = "";
    }
}