using Microsoft.AspNetCore.Identity;
using Mobitek.CRM.Entities.Enums;
using System.Collections.Generic;

namespace Mobitek.CRM.Entities
{
    /// <summary>
    /// Veritabanını AspnetUsers tablosuna karşılık gelen model.
    /// İçerisinde property olmamasının sebebi Microsoft.AspNetCore.Identity kütüphanesinin IdentityUser class'ını inherit ediyor olmasından ötürüdür.
    /// IdentityUser class'ı içerisinde temel property'leri ( kolonları ) barındırmaktadır. Bu tabloya ekstra bir kolon eklenmek istendiği zaman
    /// User class'ı içerisine yeni property tanımlaması yapılması gerekir.
    /// 
    /// #engin: User ile Customer cdlassları bir olarak kabul ediliyor. Bu ayrım UserType propertysi tarafından belirlenecek.
    /// </summary>
    public class User : IdentityUser, IEntity
    {
        public UserType UserType { get; set; } //Seo, Sem, or Customer
        public Role Role { get; set; } //Superadmin, seocu, semci, müşteri
        public string Department { get; set; } //??

        #region Navigation Properties
        public List<Project> Projects { get; set; }
        public List<Project> CustomerProjects { get; set; }
        #endregion


    }
}
