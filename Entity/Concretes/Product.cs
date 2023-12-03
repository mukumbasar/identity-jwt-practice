using Entity.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public string Brand { get; set; } = null!;

        public AppUser AppUser { get; set; }
        public string AppUserId { get; set; } 
    }
}
