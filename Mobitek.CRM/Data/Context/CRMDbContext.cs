using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Mobitek.CRM.Entities;

namespace Mobitek.CRM.Data.Context
{
    /// <summary>
    /// DbContext, AspnetIdentity kullanıldığı için IdentityDbContext class'ından miras alıyor
    /// IdentityDbContext'e user ve role tabloları için hangi modelleri kullanacağımızı generic olarak geçiyoruz.
    /// IdentityDbContext'in diğer overload'larına ihtiyacımız bu versiyon işimizi görür.
    /// </summary>
    public class CRMDbContext : IdentityDbContext<User, Role, string> 
    {
        public CRMDbContext(DbContextOptions<CRMDbContext> options) : base(options)
        {
        }
        public DbSet<Project> Projects { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    Id = "1",
                    Name = "Project1",
                },
                new Project
                {
                    Id = "2",
                    Name = "Project2",
                }
            );

            ///Summary
            ///Tabloların arasındaki bazı ilişkilendirmeler aşağıda işlenmiştir.
            ///Summary

            ///SEOExpert (User) - Projects (Project) 1-M

            modelBuilder.Entity<Project>()
                .HasOne(a => a.Expert)
                .WithMany(b => b.Projects);

            ///CustomerAccountable (User) - CustomerProjects (Project) 1-M

            modelBuilder.Entity<Project>()
                .HasOne(a => a.Customer)
                .WithMany(b => b.CustomerProjects);

            base.OnModelCreating(modelBuilder);
        }
    }
}
