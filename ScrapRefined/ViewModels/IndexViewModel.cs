using ScrapRefined.Data;
using ScrapRefined.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapRefined.ViewModels
{
    public class IndexViewModel
    {
        ProductRepository _productRepository;
        public IEnumerable<Product> Products { get; set; } = new List<Product>();
        public IndexViewModel(ProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task LoadProducts()
        {
            Products = await _productRepository.GetAllAsync();
        }
    }
}
