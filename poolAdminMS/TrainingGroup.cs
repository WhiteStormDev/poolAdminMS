//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace poolAdminMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class TrainingGroup
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TrainingGroup()
        {
            this.Abonements = new HashSet<Abonement>();
            this.CalendarTimeRows = new HashSet<CalendarTimeRow>();
            this.CalendarTimeRows1 = new HashSet<CalendarTimeRow>();
            this.CalendarTimeRows2 = new HashSet<CalendarTimeRow>();
            this.CalendarTimeRows3 = new HashSet<CalendarTimeRow>();
            this.CalendarTimeRows4 = new HashSet<CalendarTimeRow>();
            this.CalendarTimeRows5 = new HashSet<CalendarTimeRow>();
        }
    
        public int Id { get; set; }
        public string GroupName { get; set; }
        public Nullable<int> CoachId { get; set; }
        public byte[] Color { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Abonement> Abonements { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalendarTimeRow> CalendarTimeRows { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalendarTimeRow> CalendarTimeRows1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalendarTimeRow> CalendarTimeRows2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalendarTimeRow> CalendarTimeRows3 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalendarTimeRow> CalendarTimeRows4 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CalendarTimeRow> CalendarTimeRows5 { get; set; }
    }
}
