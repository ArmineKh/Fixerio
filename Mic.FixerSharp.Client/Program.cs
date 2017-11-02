using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.FixerSharp.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("http://api.fixer.io");
            var request = new RestRequest("latest", Method.GET);

            IRestResponse<Exchange> response = client.Execute<Exchange>(request);
            Exchange data = response.Data;
            //IRestResponse response = client.Execute(request);
            //if (response.StatusCode == System.Net.HttpStatusCode.OK)
            //{
            //    var content = response.Content;
            //}



            Console.ReadLine();
            string json = File.ReadAllText(@"json1.json");
            Exchange m = JsonConvert.DeserializeObject<Exchange>(json);

            Console.WriteLine(m.Base);
            Console.WriteLine(m.Base);
        }
    }
}
