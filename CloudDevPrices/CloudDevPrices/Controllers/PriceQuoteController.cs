using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CloudDevPrices.controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceQuoteController : ControllerBase
    {
        [HttpGet]
        public string Hello()
        {
            return "Hello";
        }
    }
}
