using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using rlhTest.Models.DataModel;

namespace rlhTest.Models.HelperModel
{
    public class ContDestinationMaster
    {
        public int C_Co_DM_id { get; set; }
        public string Destination_Name { get; set; }


        public List<ContDestinationMaster> Converter(List<cont_destination_master> destination_Masters)
        {
            var list = from destpack in destination_Masters
                       select new ContDestinationMaster
                       {

                           C_Co_DM_id = destpack.C_Co_DM_id,
                           Destination_Name = destpack.Destination_Name,
                         

                       };
            list = list.ToList();
            return (List<ContDestinationMaster>)list;
        }

    }
}