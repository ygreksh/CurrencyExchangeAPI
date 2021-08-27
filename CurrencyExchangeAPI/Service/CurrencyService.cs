using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CurrencyExchangeAPI
{
    public class CurrencyService
    {
        public async Task<CurrencyResponse> GetExchangeRate()
        {
            string _token = "6f4e6254cce34c899e27f556ba3bb5a3";
            
            HttpResponseMessage responseMessage;
            CurrencyResponse currencyResponse;
            using (HttpClient client = new HttpClient())
            {
                //client.DefaultRequestHeaders.Authorization = AuthenticationHeaderValue.Parse(_token);
                responseMessage = await client.GetAsync($"https://openexchangerates.org/api/latest.json?app_id={_token}");
                responseMessage.EnsureSuccessStatusCode();
                string serializedMessage = await responseMessage.Content.ReadAsStringAsync();
                Console.WriteLine(serializedMessage);
                //currencyResponse = JsonConvert.DeserializeObject<CurrencyResponse>(serializedMessage);
            }
            //return currencyResponse;
            return null;
        } 
    }
}