using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Mobitek.CRM.Data.Context;
using Mobitek.CRM.Entities;

namespace Mobitek.CRM
{
    public static class ServiceCollectionExtensions
    {
        /// <summary>
        /// Mssql Veritabanı bağlantısı için gerekli ayarlar.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        public static void CustomConfigureDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<CRMDbContext>(opts =>
            {
                opts.UseSqlServer(configuration["ConnectionStrings:MobitekCrmConnStr"]);
            });
        }


        /// <summary>
        /// AspnetIdentity configuration extension
        /// </summary>
        /// <param name="services"></param>
        public static void CustomConfigureIdentity(this IServiceCollection services)
        {
            services.AddIdentity<User, Role>(opts =>
            {
                //https://docs.microsoft.com/en-us/dotnet/api/microsoft.aspnetcore.identity.useroptions.allowedusernamecharacters?view=aspnetcore-2.2

                opts.User.RequireUniqueEmail = true;
                opts.User.AllowedUserNameCharacters = "abcçdefgğhıijklmnoçpqrsştuüvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._";

                opts.Password.RequiredLength = 4;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<CRMDbContext>().AddDefaultTokenProviders();

            CookieBuilder cookieBuilder = new CookieBuilder();

            cookieBuilder.Name = "MyBlog";
            cookieBuilder.HttpOnly = false;
            cookieBuilder.SameSite = SameSiteMode.Lax;
            cookieBuilder.SecurePolicy = CookieSecurePolicy.SameAsRequest;

            services.ConfigureApplicationCookie(opts =>
            {
                opts.LoginPath = new PathString("/Home/Login");
                opts.LogoutPath = new PathString("/Member/LogOut");
                opts.Cookie = cookieBuilder;
                opts.SlidingExpiration = true;
                opts.ExpireTimeSpan = System.TimeSpan.FromDays(60);
                opts.AccessDeniedPath = new PathString("/Member/AccessDenied");
            });

        }

    }
}

