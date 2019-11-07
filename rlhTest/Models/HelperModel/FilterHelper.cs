using rlhTest.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rlhTest.Models.HelperModel
{
    public class FilterHelper
    {
        public List<package_master> packFilter(Filters filter)
        {
            connectClass conn = new connectClass();
            List<package_master> intermedate = new List<package_master>();
            List<package_master> packages = conn.GetPackByCount(filter.person);
            if (filter.price1 == true)
            {
                intermedate.AddRange((packages.Where(e => e.Package_Price <= 50000).ToList()));
               
            }
            if (filter.price2 == true)
            {
                intermedate.AddRange((packages.Where(e => e.Package_Price > 50000 && e.Package_Price <= 100000).ToList()));
                
            }
            if (filter.price3 == true)
            {
                intermedate.AddRange((packages.Where(e => e.Package_Price > 100000 && e.Package_Price <= 200000).ToList()));
                
            }
            if (filter.price4 == true)
            {
                intermedate.AddRange((packages.Where(e => e.Package_Price > 200000 && e.Package_Price <= 500000).ToList()));
                
            }
            return intermedate;
        }

        public List<package_master> packFilterCont(Filters filter)
        {
            connectClass conn = new connectClass();
            List<package_master> intermedate = new List<package_master>();
            List<package_master> packages = conn.GetPackByCont(filter.cont);
            if (filter.price1 == true)
            {
                intermedate.AddRange((packages.Where(e => e.Package_Price <= 50000).ToList()));

            }
            if (filter.price2 == true)
            {
                intermedate.AddRange((packages.Where(e => e.Package_Price > 50000 && e.Package_Price <= 100000).ToList()));

            }
            if (filter.price3 == true)
            {
                intermedate.AddRange((packages.Where(e => e.Package_Price > 100000 && e.Package_Price <= 200000).ToList()));

            }
            if (filter.price4 == true)
            {
                intermedate.AddRange((packages.Where(e => e.Package_Price > 200000 && e.Package_Price <= 500000).ToList()));

            }
            return intermedate;
        }

        public List<package_master> packFilterKey(Filters filter)
        {
            connectClass conn = new connectClass();
            List<package_master> intermedate = new List<package_master>();
            List<package_master> packages = conn.GetKeyPackage(filter.word);
            if (filter.price1 == true)
            {
                intermedate.AddRange((packages.Where(e => e.Package_Price <= 50000).ToList()));

            }
            if (filter.price2 == true)
            {
                intermedate.AddRange((packages.Where(e => e.Package_Price > 50000 && e.Package_Price <= 100000).ToList()));

            }
            if (filter.price3 == true)
            {
                intermedate.AddRange((packages.Where(e => e.Package_Price > 100000 && e.Package_Price <= 200000).ToList()));

            }
            if (filter.price4 == true)
            {
                intermedate.AddRange((packages.Where(e => e.Package_Price > 200000 && e.Package_Price <= 500000).ToList()));

            }
            return intermedate;
        }
    }
}