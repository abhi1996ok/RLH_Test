using System;
using System.Collections.Generic;
using System.Linq;
using rlhTest.Models.DataModel;

/// <summary>
/// PackageMaster helper class to covert the Packages in the 
/// desired from or valid form
/// </summary>
namespace rlhTest.Models.HelperModel
{
    public class PackageMaster
    {
        public int C_PM_id { get; set; }
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
                           C_PM_id = pck.C_PM_id,
                           No_of_Days = pck.No_of_Days,
                           Package_Description = pck.Package_Description,
                           Package_Name = pck.Package_Name,
                           Package_Price = pck.Package_Price
                       };
            list = list.ToList();
            return (List<PackageMaster>)list;
        }

        public List<PackageMaster> PackConvter2(List<package_dest_master> list)
        { 
                var listData = from pck in list
                              
                       select new PackageMaster()
                       {
                           Booking_Enabled_Flag = pck.package_master.Booking_Enabled_Flag,
                           Creation_Date = pck.package_master.Creation_Date,
                           Customization_Allowed_Flag = pck.package_master.Customization_Allowed_Flag,
                           C_PM_id = pck.package_master.C_PM_id,
                           No_of_Days = pck.package_master.No_of_Days,
                           Package_Description = pck.package_master.Package_Description,
                           Package_Name = pck.package_master.Package_Name,
                           Package_Price = pck.package_master.Package_Price
                       };

            listData = listData.ToList();
           
            return (List<PackageMaster>)listData;
        }

        //public object PackConvter(bool v)
        //{
        //    throw new NotImplementedException();
        //}

        public PackageMaster singlePack(package_master package)
        {
            PackageMaster pack = new PackageMaster();

            pack.Booking_Enabled_Flag = package.Booking_Enabled_Flag;
            pack.Creation_Date = package.Creation_Date;
            pack.Customization_Allowed_Flag = package.Customization_Allowed_Flag;
            pack.C_PM_id = package.C_PM_id;
            pack.No_of_Days = package.No_of_Days;
            pack.Package_Description = package.Package_Description;
            pack.Package_Name = package.Package_Name;
            pack.Package_Price = package.Package_Price;
            return pack;
        }
    }
}