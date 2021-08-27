using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CurrencyExchangeAPI
{
    public class CurrencyService
    {
        public async Task<CurrencyResponse> GetExchangeRate()
        {
            string _token = "6f4e6254cce34c899e27f556ba3bb5a3";
            List<Currency> list;
            HttpResponseMessage responseMessage;
            CurrencyResponse currencyResponse;
            JObject jObject = null;
            using (HttpClient client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(_token);
                //responseMessage = await client.GetAsync($"https://openexchangerates.org/api/latest.json?app_id={_token}");
                responseMessage = await client.GetAsync("https://api.privatbank.ua/p24api/pubinfo?exchange&json&coursid=11");
                
                responseMessage.EnsureSuccessStatusCode();
                string serializedMessage = await responseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(serializedMessage);
                //currencyResponse = JsonConvert.DeserializeObject<CurrencyResponse>(serializedMessage);
                list = JsonConvert.DeserializeObject<List<Currency>>(serializedMessage);
                //jObject = JObject.Parse(serializedMessage);
                Console.WriteLine(list.Capacity);
                foreach (var currency in list)
                {
                    Console.WriteLine($"{currency.ccy}, {currency.base_ccy}, {currency.buy}, {currency.sale}");
                }
            }
            //return currencyResponse;
            return null;
        } 
    }
}