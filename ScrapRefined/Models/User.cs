using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ScrapRefined.Models
{
    public enum Role
    {
        Admin,
        User
    }

    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Points { get; set; }
        public Role Role { get; set; }
        public List<Product> FavouriteProducts { get; set; }
    }
}
