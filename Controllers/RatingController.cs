using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RatingService.Boundaries;
using RatingService.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RatingService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _ratingService;
        private readonly ILogger<RatingController> _logger;

        public RatingController(ILogger<RatingController> logger, IRatingService ratingService)
        {
            _logger = logger;
            _ratingService = ratingService;
        }

        [HttpGet("{baseRate}/{value}")]
        public Task<IEnumerable<ConvertRateBoundary>> Get(string baseRate, double value, [FromQuery] string[] symbol)
        {
            return _ratingService.GetRates(baseRate, value, symbol);
        }
    }
}
