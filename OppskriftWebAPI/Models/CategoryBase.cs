using System;

namespace OppskriftWebAPI.Models
{
    /// <summary>
    /// Baseclass for kategoriske database entries
    /// </summary>
    /// <remarks>
    /// Innholder ID, Navn og Times Used
    /// </remarks>
    public class CategoryBase
    {
        /// <summary>
        /// GUID for primary Key i Db
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Navn på enhet i database
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Antall ganger enheten er tatt i bruk.
        /// </summary>
        public int TimesUsed { get; set; }
    }
}
