namespace Mobitek.CRM.Models.ProjectModels
{
    using Mobitek.CRM.Entities;
    /// <summary>
    /// Kullanıcı detay metodu modeli
    /// </summary>
    public class ProjectDetailViewModel
    {
        /// <summary>
        /// Detay bilgisi sorgulanan kullanıcı
        /// </summary>
        public Project Project { get; set; }
        /// <summary>
        /// Hata mesajı
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
