﻿using iRacingStats.Core.HttpClients;
using iRacingStats.Core.Constants;
using iRacingStats.Core.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace iRacingStats.Api.Controllers.Stats
{
    [Obsolete("Calling this endpoint externally appears to have been deprecated.")]
    [Route("api/stats/[controller]")]
    [ApiController]
    public class DriverController : ControllerBase
    {
        private readonly IRacingHttpClient _iracingHttpClient;

        public DriverController(IRacingHttpClient iracingHttpClient)
        {
            _iracingHttpClient = iracingHttpClient;
        }

        [HttpGet("{search}")]
        public async Task<string> DriverStats(string search)
        {
            Dictionary<string, string> data = new()
            {
                { "search", search }
            };

            return await _iracingHttpClient.PostRequestAndGetResponse(URLs.DRIVER_STATS, data);
        }
    }
}