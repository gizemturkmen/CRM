using Mobitek.CRM.Entities;
using System.ComponentModel.DataAnnotations;

namespace Mobitek.CRM.Models.ProjectModels
{
    /// <summary>
    /// Proje oluşturma metodunda kullanıcıdan istenecek bilgileri karşılayan modeldir.
    /// </summary>
    public class ProjectAddViewModel
    {
        [Required]
        public Project Project { get; set; }
        public string ErrorMessage { get; set; }
    }
}