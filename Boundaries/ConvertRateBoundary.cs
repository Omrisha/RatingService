using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingService.Boundaries
{
    [Serializable]
    public class ConvertRateBoundary
    {
        public string Name { get; set; }
        public double Value { get; set; }
    }
}
