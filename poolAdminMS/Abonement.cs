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
    
    public partial class Abonement
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Abonement()
        {
            this.VisitDates = new HashSet<VisitDate>();
        }
    
        public int Id { get; set; }
        public Nullable<int> VisitCount { get; set; }
        public System.DateTime DateEnd { get; set; }
        public int ClientId { get; set; }
        public Nullable<int> TrainingGroupId { get; set; }
        public int VisitTypeId { get; set; }
        public int ServiceTypeId { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual TrainingGroup TrainingGroup { get; set; }
        public virtual ServiceType ServiceType { get; set; }
        public virtual VisitType VisitType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VisitDate> VisitDates { get; set; }
    }
}
