using System.Net;

namespace Mic.FixerSharp.Framework
{
    class FixerResponse : IFixerResponse
    {
        public HttpStatusCode StatusCode { get; set; }

        public Exchange Exchange { get; set; }
    }
}