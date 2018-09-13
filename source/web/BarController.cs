using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using Bar;
namespace web
{
    [ApiController]
    [Route("/bar")]
    public class BarController 
    {
        private readonly Bar.Bar _bar;
        public BarController(Bar.Bar bar)
        {
            _bar = bar;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return _bar.GetBar();
        }
    }
}