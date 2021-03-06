using System;
using System.Threading.Tasks;

namespace CurrencyExchangeAPI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            CurrencyResponse currencyResponse;
            CurrencyService service = new CurrencyService();
            currencyResponse = await service.GetExchangeRate();
            Console.WriteLine(currencyResponse);
            foreach (var item in currencyResponse.Rates)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}