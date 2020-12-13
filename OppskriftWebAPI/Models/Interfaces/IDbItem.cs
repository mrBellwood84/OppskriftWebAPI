using System;

namespace OppskriftWebAPI.Models
{
    /// <summary>
    /// Minstekrav for modeller 
    /// </summary>
    /// <remarks>
    /// Felt for opprettelse og redigering er kommentert ut intill videre
    /// </remarks>
    interface IDbItem
    {
        /// <summary>
        /// GUID for Primary Key i database
        /// </summary>
        public Guid Id { get; set; }
        
    }
}
