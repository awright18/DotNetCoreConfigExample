using Microsoft.Extensions.Options;
using System;
namespace Foo
{
    public class Foo
    {
        private readonly FooOptions fooOptions;
        public Foo(IOptions<FooOptions> options)
        {
            fooOptions = options.Value;
        }

        public string GetFoo()
        {
            return fooOptions.Foo;
        }
    }
}