using System.ComponentModel.DataAnnotations;

namespace Mobitek.CRM.Models.UserModels
{
    /// <summary>
    /// Kullanıcı oluşturma metodunda kullanıcıdan istenecek bilgileri karşılayan modeldir.
    /// </summary>
    public class UserAddModel
    {
        [Required]
        public string Name { get; set; }
    }
}
