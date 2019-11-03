using Renty.DTO;

namespace Renty.Search
{
    interface IScraper
    {
        Apartment ScrapePage(string url);
    }
}
