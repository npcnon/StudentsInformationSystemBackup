//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentsInformationSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class TblSchedule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TblSchedule()
        {
            this.TblSubjInfoes = new HashSet<TblSubjInfo>();
        }
    
        public int schedule_id { get; set; }
        public Nullable<int> room { get; set; }
        public string class_day { get; set; }
        public string class_hour { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TblSubjInfo> TblSubjInfoes { get; set; }
    }
}
