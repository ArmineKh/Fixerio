using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mic.FixerSharp.Framework
{
    public sealed class FixerClient
    {
        public FixerClient()
        {
            _client = new RestClient("http://api.fixer.io");
        }

        private RestClient _client;

        public IFixerResponse GetLatest()
        {
            return OnGet("latest");
            //var request = new RestRequest("latest", Method.GET);
            //IRestResponse<Exchange> response = _client.Execute<Exchange>(request);
            //return response.Data;
        }

        public IFixerResponse GetLatest(CurrencyType currency)
        {
            return GetLatest(currency.ToString());
        }

        //http://api.fixer.io/latest?base=USD
        public IFixerResponse GetLatest(string currency)
        {
            return OnGet($"latest?base={currency}");
        }

        //http://api.fixer.io/latest?symbols=USD,GBP
        public IFixerResponse GetLatest(params string[] symbols)
        {
            var sb = new StringBuilder();
            foreach (string item in symbols)
                sb.Append(item).Append(",");

            return OnGet($"latest?symbols={sb.ToString().TrimEnd(',')}");
        }

        /// <summary>
        /// http://api.fixer.io/2000-01-03
        /// </summary>
        /// <param name="date"></param>
        /// <returns></returns>
        public IFixerResponse Get(DateTime date)
        {
            return OnGet(date.ToString("yyyy-MM-dd"));
            //var request = new RestRequest(date.ToString("yyyy-MM-dd"), Method.GET);
            //IRestResponse<Exchange> response = _client.Execute<Exchange>(request);
            //return response.Data;
        }

        private IFixerResponse OnGet(string method)
        {
            var request = new RestRequest(method, Method.GET);
            IRestResponse<Exchange> response = _client.Execute<Exchange>(request);

            return new FixerResponse
            {
                Exchange = response.Data,
                StatusCode = response.StatusCode
            };
        }
    }
}