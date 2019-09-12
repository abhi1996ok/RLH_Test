using System.Collections.Generic;
using System.Linq;

namespace rlhTest.Models.HelperModel
{
    public class PackageMaster
    {
        public int C_PM_id { get; set; }
        public int C_DM_id { get; set; }
        public string Package_Name { get; set; }
        public string Package_Description { get; set; }
        public int No_of_Days { get; set; }
        public int Package_Price { get; set; }
        public sbyte Booking_Enabled_Flag { get; set; }
        public sbyte Customization_Allowed_Flag { get; set; }
        public System.DateTime Creation_Date { get; set; }

        public List<PackageMaster> PackConvter(List<package_master> package_Masters)
        {
            var list = from pck in package_Masters
                       select new PackageMaster()
                       {
                           Booking_Enabled_Flag = pck.Booking_Enabled_Flag,
                           Creation_Date = pck.Creation_Date,
                           Customization_Allowed_Flag = pck.Customization_Allowed_Flag,
                           C_DM_id = pck.C_DM_id,
                           C_PM_id = pck.C_PM_id,
                           No_of_Days = pck.No_of_Days,
                           Package_Description = pck.Package_Description,
                           Package_Name = pck.Package_Name,
                           Package_Price = pck.Package_Price
                       };
            list = list.ToList();
            return (List<PackageMaster>)list;
        }
    }
}