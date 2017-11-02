using System.Collections.Generic;

namespace Mic.FixerSharp.Framework
{
    public class Exchange
    {
        public string Base { get; set; }
        public string Date { get; set; }
        public Dictionary<string, double> Rates { get; set; }
    }
}