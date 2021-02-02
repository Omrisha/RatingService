using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingService.Boundaries
{
    [Serializable]
    public class BaseRateBoundary
    {
        [JsonProperty("base")]
        public string Base { get; set; }
        [JsonProperty("rates")]
        public Dictionary<string, double> Rates { get; set; }
    }
}
