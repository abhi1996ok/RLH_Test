//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace rlhTest.Models.DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class package_dest_master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public package_dest_master()
        {
            this.package_city_master = new HashSet<package_city_master>();
        }
    
        public int C_PDM_id { get; set; }
        public int C_PM_id { get; set; }
        public int C_Co_DM_id { get; set; }
        public int C_CDM_id { get; set; }
    
        public virtual cont_destination_master cont_destination_master { get; set; }
        public virtual country_dest_master country_dest_master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<package_city_master> package_city_master { get; set; }
        public virtual package_master package_master { get; set; }
    }
}