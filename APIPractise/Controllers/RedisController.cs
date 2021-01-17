using EasyCaching.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreApiPractise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisController : ControllerBase
    {

        public  string source = "https://www.youtube.com/watch?v=TS7Ttszh5aM"; 


        private IEasyCachingProvider cachingProvider;
        private IEasyCachingProviderFactory cachingProviderFactory;



        public RedisController(IEasyCachingProviderFactory _factory)
        {
            cachingProviderFactory = _factory;
            this.cachingProvider = this.cachingProviderFactory.GetCachingProvider("redis1");

        }

        [HttpGet("setQueue")]
        public IActionResult SetItemQueue()
        {

            this.cachingProvider.Set<string>(cacheKey: "key123", cacheValue: "this is may data", expiration: TimeSpan.FromDays(10));
            return Ok();
        }

        [HttpPost("getval")]

        public IActionResult GetValue(string key)
        {
            var item = this.cachingProvider.Get<string>(cacheKey: key);

            return Ok(item);
        
        
        }
    }
}
