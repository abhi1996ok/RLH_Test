using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Net.Http.Headers;
using rlhTest.Models.DataModel;

namespace rlhTest.Models.HelperModel
{
    public class connectClass
    {
        string baseuri = "http://localhost:54134/cont_dest/getdata";
        public List<cont_destination_master> GetAllContDest()
        {
            //string uri = baseuri + "/?id=" + id + "&destid=" + destid;
            using (HttpClient httpclient = new HttpClient())
            {
                Task<string> response = httpclient.GetStringAsync(baseuri);
                var result = response.Result;

                return JsonConvert.DeserializeObject<List<cont_destination_master>>(result);
            }
        }

        public List<package_master> GetAllPackages()
        {
            string uri = "http://localhost:54134/package/GetAllPackage";
            using (HttpClient httpClient = new HttpClient())
            {
                Task<string> response = httpClient.GetStringAsync(uri);
                var result = response.Result;

                return JsonConvert.DeserializeObject<List<package_master>>(result);
            }
        }

        public List<package_master> GetKeyPackage(string str)
        {
            string uri = "http://localhost:54134/keyword/GetKeyPackage/"+"?type="+str;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<string> response = httpClient.GetStringAsync(uri);
                var result = response.Result;

                return JsonConvert.DeserializeObject<List<package_master>>(result);
            }
        }

        public List<package_master> GetDestAllPack( string country)
        {
            string baseUri = "http://localhost:54134/country_dest/GetCountPackage"+"?name="+country;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<string> response = httpClient.GetStringAsync(baseUri);
                var result = response.Result;

                return JsonConvert.DeserializeObject<List<package_master>>(result);
            }
        }

        public List<package_master> GetOfferPack()
        {
            string uri = "http://localhost:54134/keyword/GetOfferPackage";
            using (HttpClient httpClient = new HttpClient())
            {
                Task<string> response = httpClient.GetStringAsync(uri);
                var result = response.Result;

                return JsonConvert.DeserializeObject<List<package_master>>(result);
            }
        }

        public List<package_master> GetPackByCont(string contName )
        {
            string uri = "http://localhost:54134/cont_dest/GetPackCont"+"?contName="+contName;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<string> response = httpClient.GetStringAsync(uri);
                var result = response.Result;

                return JsonConvert.DeserializeObject<List<package_master>>(result);
            }
        }

        public List<package_master> GetPackByCount(int person)
        {
            string uri = "http://localhost:54134/package/GetPackByCount" + "?person=" + person;
            using (HttpClient httpClient = new HttpClient())
            {
                Task<string> response = httpClient.GetStringAsync(uri);
                var result = response.Result;

                return JsonConvert.DeserializeObject<List<package_master>>(result);
            }
        }


        //    public List<package_master> GetDestByKey(string str)
        //    {
        //        string uri = "http://localhost:54134/api/keyword_master" + "?id=0&type=" + str;
        //        using (HttpClient httpClient = new HttpClient())
        //        {
        //            Task<String> response = httpClient.GetStringAsync(uri);
        //            var result = response.Result;

        //            return JsonConvert.DeserializeObject<List<package_master>>(result);
        //        }
        //    }



        //    //public List<destination_master> GetVFreeDest(sbyte visa)
        //    //{
        //    //    string uri = "http://localhost:54134/api/destination_master" + "?id=0&visa=" + visa;
        //    //    using (HttpClient httpClient = new HttpClient())
        //    //    {
        //    //        Task<String> response = httpClient.GetStringAsync(uri);

        //    //        var result = response.Result;

        //    //        return JsonConvert.DeserializeObject<List<destination_master>>(result);
        //    //    }
        //    //}

        public bool PostQuery([FromBody]query_master query_master)
        {
            string uri = "http://localhost:54134/api/query_master" + "/?query_master=" + query_master;
            using (HttpClient httpClient = new HttpClient())
            {
                var myContent = JsonConvert.SerializeObject(query_master);
                var buffer = System.Text.Encoding.UTF8.GetBytes(myContent);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");



                var response = httpClient.PostAsync(uri, byteContent).Result;

                var result = response.StatusCode;

                return true;
            }

        }


    }
}