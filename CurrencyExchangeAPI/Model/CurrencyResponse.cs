using System.Collections;
using System.Collections.Generic;

namespace CurrencyExchangeAPI
{
    public class CurrencyResponse
    {
        public string Disclaimer { get; set; }
        public string License { get; set; }
        public int TimeStamp { get; set; }
        public string Base { get; set; }
        //public IEnumerable<Currency> Rates { get; set; }
        public Dictionary<string, double> Rates { get; set; }
    }
}