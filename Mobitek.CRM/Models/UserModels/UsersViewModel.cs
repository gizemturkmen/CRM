using Mobitek.CRM.Entities;
using System.Collections.Generic;

namespace Mobitek.CRM.Models.UserModels
{
    /// <summary>
    /// Tüm kullanıcıları listeleme modeli
    /// </summary>
    public class UsersViewModel
    {
        /// <summary>
        /// Listelenecek kullanıcılar
        /// </summary>
        public List<User> Users { get; set; }
    }
}
