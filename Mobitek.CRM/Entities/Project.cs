using System;
using System.Collections.Generic;

namespace Mobitek.CRM.Entities
{
    public class Project : EntityBase<string>
    {

        public string Name { get; set; } 

        public string Budget { get; set; } 
        public string Status { get; set; } 
        /// <summary>
        /// Navigation Properties kısmı ilişki propertyleridir. Hangi Entity kiminle ilişkili, bu alanda belirtiyoruz.
        /// </summary>

        #region Navigation Properties
        public string ExpertId { get; set; } 
        public User Expert { get; set; }
        public string CustomerId { get; set; } 
        public User Customer { get; set; }
        #endregion

    }
}
