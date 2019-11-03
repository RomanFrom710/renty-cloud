using HtmlAgilityPack;

namespace Renty.Search
{
    internal abstract class WebLoader : ILoader
    {
        private readonly HtmlWeb _web;

        internal WebLoader(HtmlWeb web)
        {
            _web = web;
        }

        public HtmlDocument LoadPage(string url)
        {
            return _web.Load(url);
        }
    }
}
