//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rlhTest.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class client_package_city_master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public client_package_city_master()
        {
            this.client_city_activity_master = new HashSet<client_city_activity_master>();
        }
    
        public int C_CPCM_id { get; set; }
        public Nullable<int> C_CPM_id { get; set; }
        public Nullable<int> C_CM_id { get; set; }
        public Nullable<int> Number_Of_Days_In_city { get; set; }
    
        public virtual city_master city_master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<client_city_activity_master> client_city_activity_master { get; set; }
        public virtual client_package_master client_package_master { get; set; }
    }
}