using System.ComponentModel.DataAnnotations;

namespace Mobitek.CRM.Entities.Enums
{
    public enum UserType
    {
        [Display(Name = "Müşteri")]
        Customer,
        [Display(Name ="Uzman")]
        Expert
    }
}
