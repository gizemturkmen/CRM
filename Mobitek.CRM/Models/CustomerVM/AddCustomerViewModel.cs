using System.ComponentModel.DataAnnotations;

namespace Mobitek.CRM.Models.CustomerVM
{
    /// <summary>
    /// Müşteri oluşturma metodunda kullanıcıdan istenecek bilgileri karşılayan modeldir.
    /// </summary>
    public class AddCustomerViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
