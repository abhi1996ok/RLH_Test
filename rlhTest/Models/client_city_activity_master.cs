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
    
    public partial class client_city_activity_master
    {
        public int C_CCAM_id { get; set; }
        public int C_CPCM_id { get; set; }
        public int C_AM_id { get; set; }
        public int Sequence_Numeber { get; set; }
        public int Day_Sequence_Number { get; set; }
    
        public virtual activity_master activity_master { get; set; }
        public virtual client_package_city_master client_package_city_master { get; set; }
    }
}
