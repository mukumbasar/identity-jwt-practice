using Entity.Abstracts;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concretes
{
    public class AppRole : IdentityRole, IEntity
    {
        public DateTime CreationTime { get; set; }

        public AppRole()
        {
            CreationTime = DateTime.Now;
        }
    }
}
