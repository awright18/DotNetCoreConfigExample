using Microsoft.Extensions.Options;
using Microsoft.AspNetCore.Mvc;
using Foo;
namespace web
{
    [ApiController]
    [Route("/foo")]
    public class FooController
    {
        private readonly Foo.Foo _foo;
        public FooController(Foo.Foo foo)
        {
            _foo = foo;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return _foo.GetFoo();
        }
    }
}