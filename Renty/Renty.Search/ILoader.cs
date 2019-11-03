using HtmlAgilityPack;

namespace Renty.Search
{
    public interface ILoader
    {
        HtmlDocument LoadPage(string url);
    }
}
