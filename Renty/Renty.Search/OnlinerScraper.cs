using Renty.DTO;

namespace Renty.Search
{
    internal class OnlinerScraper : IScraper
    {
        private readonly ILoader _loader;

        internal OnlinerScraper(ILoader loader)
        {
            _loader = loader;
        }

        public Apartment ScrapePage(string url)
        {
            var page = _loader.LoadPage(url);
        }
    }
}
