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
    
    public partial class client_package_master
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public client_package_master()
        {
            this.client_package_city_master = new HashSet<client_package_city_master>();
            this.favourite_master = new HashSet<favourite_master>();
        }
    
        public int C_CPM_id { get; set; }
        public int C_DM_id { get; set; }
        public int C_PM_id { get; set; }
        public string Package_Name { get; set; }
        public string Package_Description { get; set; }
        public int Number_Of_Days { get; set; }
        public int Package_Price { get; set; }
        public System.DateTime Creation_Date { get; set; }
        public sbyte Booking_Flag { get; set; }
        public int C_CUM_id { get; set; }
    
        public virtual client_master client_master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<client_package_city_master> client_package_city_master { get; set; }
        public virtual cont_destination_master cont_destination_master { get; set; }
        public virtual package_master package_master { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<favourite_master> favourite_master { get; set; }
    }
}