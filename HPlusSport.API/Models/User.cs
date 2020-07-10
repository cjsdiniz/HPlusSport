using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HPlusSport.API.Models
{
    public class User
    {
        public int Id { get; set; }
        public string   Email { get; set; }
        public string   Name { get; set; }
        public virtual List<Order> Orders { get; set; }
        public virtual List<Product> Products { get; set; }
    }
}
