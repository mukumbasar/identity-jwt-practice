using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Extensions
{
    public static class BLDepedencies
    {
        public static void AddBLDependencies(this IServiceCollection services, Assembly configFromAssembly)
        {
            services.AddAutoMapper(Assembly.GetExecutingAssembly(), configFromAssembly);

            #region Custom Services
            //services.AddScoped<IEmailService, EmailManager>();
            //services.AddScoped<IAccountService, AccountManager>();
            //services.AddScoped<IMakaleService, MakaleManager>();
            #endregion
        }
    }
}
