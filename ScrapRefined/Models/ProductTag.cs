using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScrapRefined.Models
{
    public class ProductTag
    {
        public int Id { get; set; }
        public Tag Tag { get; set; }
        public Product Product { get; set; }

    }
}
