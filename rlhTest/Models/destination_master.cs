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
    
    public partial class destination_master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public destination_master()
        {
            this.city_master = new HashSet<city_master>();
            this.client_package_master = new HashSet<client_package_master>();
            this.package_master = new HashSet<package_master>();
        }
    
        public int C_DM_id { get; set; }
        public string Destination_Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<city_master> city_master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<client_package_master> client_package_master { get; set; }
        public virtual destination_image_master destination_image_master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<package_master> package_master { get; set; }
    }
}
