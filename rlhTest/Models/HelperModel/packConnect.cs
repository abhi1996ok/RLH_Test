using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace rlhTest.Models.HelperModel
{
    public class packConnect
    {
        string baseUri = "http://localhost:54134/api/package_master";
        public List<package_master> GetPackages(int id,bool destId)
        {
            string uri = baseUri +"?id="+ id+"&destId=" + destId;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<String> response = httpClient.GetStringAsync(uri);
                var result = response.Result;

                return JsonConvert.DeserializeObject<List<package_master>>(result);
            }
        }
    }
}