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
    
    public partial class country_dest_master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public country_dest_master()
        {
            this.city_master = new HashSet<city_master>();
            this.package_dest_master = new HashSet<package_dest_master>();
        }
    
        public int C_CDM_id { get; set; }
        public int C_Co_DM_id { get; set; }
        public string Country_Name { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Longitude { get; set; }
        public Nullable<sbyte> Visa_free { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<city_master> city_master { get; set; }
        public virtual cont_destination_master cont_destination_master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<package_dest_master> package_dest_master { get; set; }
    }
}
