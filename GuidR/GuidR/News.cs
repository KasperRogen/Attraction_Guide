// Shared properties between all news.

namespace GuidR
{
    public class News
    {
        public News (string header, string newsInfo, object image)
        {
            this.Header = header;
            this.NewsInfo = newsInfo;
            this.Image = image;
        }

        // Headline for the given news.
        public string Header { get; set; }

        // The description needed to explain the news.
        public string NewsInfo { get; set; }

        // A picture is needed to instance a new news.
        public object Image { get; set; }
    }
}
