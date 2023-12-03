using Entity.Abstracts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class AppUser : IdentityUser, IEntity
    {
        public string Name { get; set; } = null!;
        public string Surname { get; set; } = null!;
        public DateTime CreationTime { get; set; }

        public List<Product> Products { get; set; } = null!;

        public AppUser()
        {
            CreationTime = DateTime.Now;
        }
    }
}
