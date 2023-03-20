//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Akropol.Helpers
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fond
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fond()
        {
            this.Managers = new HashSet<Managers>();
        }
    
        public int Id { get; set; }
        public int NumberStoreys { get; set; }
        public int ArendaStoreys { get; set; }
        public System.DateTime YearCostruction { get; set; }
        public int IdLocation { get; set; }
        public int NumberRooms { get; set; }
        public int IdNumberBathrooms { get; set; }
        public bool Conditioner { get; set; }
        public decimal Summa { get; set; }
        public decimal MarketSumma { get; set; }
        public decimal ArendSumma { get; set; }
        public bool RoomArend { get; set; }
    
        public virtual Location Location { get; set; }
        public virtual NumberBathrooms NumberBathrooms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Managers> Managers { get; set; }
    }
}
