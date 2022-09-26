using Mobitek.CRM.Entities;
using System.Collections.Generic;

namespace Mobitek.CRM.Models.ProjectModels
{
    /// <summary>
    /// Tüm kullanıcıları listeleme modeli
    /// </summary>
    public class ProjectsViewModel
    {
        /// <summary>
        /// Listelenecek kullanıcılar
        /// </summary>
        public List<Project> Projects { get; set; }
    }
}
