namespace Mobitek.CRM.Models.UserModels
{
    using Mobitek.CRM.Entities;
    /// <summary>
    /// Kullanıcı detay metodu modeli
    /// </summary>
    public class UserDetailViewModel
    {
        /// <summary>
        /// Detay bilgisi sorgulanan kullanıcı
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Hata mesajı
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
