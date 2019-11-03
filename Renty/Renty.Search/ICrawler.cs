using System.Collections.Generic;

namespace Renty.Search
{
    interface ICrawler
    {
        /// <summary>
        /// Extracts apartment page urls from a site. End of crawling is determined
        /// by empty result.
        /// </summary>
        /// <param name="page">Page index (starts from 0)</param>
        IEnumerable<string> GetApartmentUrls(int page);
    }
}
