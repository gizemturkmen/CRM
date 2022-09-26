using System.ComponentModel.DataAnnotations;

namespace Mobitek.CRM.Models.Keyword
{
    /// <summary>
    /// Keyword oluşturma metodunda kullanıcıdan istenecek bilgileri karşılayan modeldir.
    /// </summary>
    public class AddKeywordViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}