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
    
    public partial class package_city_master
    {
        public int C_PCM_id { get; set; }
        public int C_PM_id { get; set; }
        public int C_CM_id { get; set; }
        public int Number_Of_Days_in_city { get; set; }
    
        public virtual city_master city_master { get; set; }
        public virtual package_master package_master { get; set; }
    }
}