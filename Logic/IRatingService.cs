using RatingService.Boundaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingService.Logic
{
    public interface IRatingService
    {
        Task<IEnumerable<ConvertRateBoundary>> GetRates(string baseRate, double value, string[] symbols);
    }
}
