using Microsoft.Extensions.Options;

namespace Bar
{
    public class Bar
    {
        private readonly BarOptions barOptions;
        public Bar(IOptions<BarOptions> options)
        {
            barOptions = options.Value;
        }

        public string GetBar()
        {
            return barOptions.Bar;
        }
    }
}