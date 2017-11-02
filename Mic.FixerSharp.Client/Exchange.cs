using System.Collections.Generic;

namespace Mic.FixerSharp.Client
{
    public class Exchange
    {
        public string Base { get; set; }
        public string Date { get; set; }
        public Dictionary<string, double> Rates { get; set; }
    }
}