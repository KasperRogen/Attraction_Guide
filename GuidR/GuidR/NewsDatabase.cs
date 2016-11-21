using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuidR
{
    public static class NewsDatabase
    {
        public static List<News> NewsList = new List<News>();

        public static void AddNews(string header, string newsInfo, object image)
        {
            NewsList.Add(new News(header, newsInfo, image));
        }
    }
}
