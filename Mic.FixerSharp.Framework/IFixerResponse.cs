using System.Net;

namespace Mic.FixerSharp.Framework
{
    public interface IFixerResponse
    {
        HttpStatusCode StatusCode { get; }
        Exchange Exchange { get; }
    }
}