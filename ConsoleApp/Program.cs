using ConsoleApp.Model;
using Flurl.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        private static readonly string mercadolibreBaseUrl = "https://api.mercadolibre.com";

        static async Task Main(string[] args)
        {
            IEnumerable<Currency> currencies = await $"{mercadolibreBaseUrl}/currencies/".GetJsonAsync<IEnumerable<Currency>>();
            currencies = await Task.WhenAll(currencies.Select(async x => await PopulateToDolar(x)).ToArray());
            
            IEnumerable<string> conversions = currencies.Select(x => x.ToDolar.HasValue ? x.ToDolar.Value.ToString("0.00000000", CultureInfo.InvariantCulture) : "N/A");
            string csvLine = string.Join(',', conversions);

            File.AppendAllText("./CurrencyConversions.csv", $"{csvLine}\n");

            using (StreamWriter file = File.CreateText($@"./Currencies_{DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")}.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                serializer.Serialize(file, currencies);
            }
        }

        private static async Task<Currency> PopulateToDolar(Currency currency)
        {
            Console.WriteLine(DateTime.Now.ToString());
            try
            {
                var currencyConversion = await $"{mercadolibreBaseUrl}/currency_conversions/search?from={currency.Id}&to=USD".GetJsonAsync<CurrencyConversion>();
                currency.ToDolar = currencyConversion.Rate;
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error converting {currency.Id} to USD: {e.Message}");
            }

            return currency;
        }
    }
}
