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
    
    public partial class booking_master
    {
        public int C_BM_id { get; set; }
        public int C_CUM_id { get; set; }
        public int Booking_Status { get; set; }
        public int C_PM_id { get; set; }
        public string Payment_Info { get; set; }
        public System.DateTime Date_Of_Booking { get; set; }
    
        public virtual client_master client_master { get; set; }
        public virtual package_master package_master { get; set; }
    }
}