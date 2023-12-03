using DAL.Contexts;
using Entity.Concretes;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IdentityConfigurations
{
    public class IdentityUserValidator : IUserValidator<AppUser>
    {
        private readonly AppDbContext _context;

        public IdentityUserValidator(AppDbContext context)
        {
            _context = context;
        }

        public Task<IdentityResult> ValidateAsync(UserManager<AppUser> userMmanager, AppUser user)
        {
            var errors = new List<IdentityError>();

            if (_context.Users.Where(u => u.Email == user.Email).Any())
            {
                errors.Add(new IdentityError() { Code = "", Description = "Başka bir email giriniz." });
            }

            if (errors.Any())
            {
                return Task.FromResult(IdentityResult.Failed(errors.ToArray()));
            }

            return Task.FromResult(IdentityResult.Success);

        }
    }
}
