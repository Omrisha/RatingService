using Newtonsoft.Json;
using RatingService.Boundaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace RatingService.Logic
{
    public class RatingServiceImpl : IRatingService
    {
        private readonly HttpClient _client;
        private string _apiKey;

        public RatingServiceImpl(HttpClient client)
        {
            _client = client;
            _apiKey = Environment.GetEnvironmentVariable("ACCESS_KEY");
        }

        public async Task<IEnumerable<ConvertRateBoundary>> GetRates(string baseRate, double value, string[] symbols)
        {
            if (baseRate == null)
            {
                throw new Exception("Please provide a city to get weather for.");
            }
            try
            {
                var response = await _client.GetAsync($"latest?access_key={_apiKey}&base={baseRate}&symbols={string.Join(",", symbols)}");

                if (response.IsSuccessStatusCode)
                {
                    var serializedString = await response.Content.ReadAsStringAsync();
                    var items = JsonConvert.DeserializeObject<BaseRateBoundary>(serializedString);

                    return items.Rates.Select(r => new ConvertRateBoundary { Name = r.Key, Value = r.Value * value });
                }
                else
                {
                    throw new Exception($"No rates found for {baseRate}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
