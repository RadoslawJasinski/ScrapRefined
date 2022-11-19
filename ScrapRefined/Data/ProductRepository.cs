using Microsoft.EntityFrameworkCore;
using ScrapRefined.DAL;
using ScrapRefined.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapRefined.Data
{
    //internal class ProductRepository
    //{
    //}

    public class ProductRepository
    {
        private readonly ScrapRefinedDbContext _dbContext;

        public ProductRepository(ScrapRefinedDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _dbContext.Products.Include(x => x.Category).ToListAsync();
        }

    }

}
