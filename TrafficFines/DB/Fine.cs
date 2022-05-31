//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TrafficFines.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fine()
        {
            this.DriverFine = new HashSet<DriverFine>();
            this.TrafficPunisment = new HashSet<TrafficPunisment>();
        }
    
        public int IDTrafficFine { get; set; }
        public string CodeOfAdminOfenses { get; set; }
        public int IDAreaOfViolation { get; set; }
        public Nullable<int> IDFinePunishment { get; set; }
        public string Description { get; set; }
        public string Punishment { get; set; }
    
        public virtual AreaOfViolation AreaOfViolation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DriverFine> DriverFine { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TrafficPunisment> TrafficPunisment { get; set; }
    }
}