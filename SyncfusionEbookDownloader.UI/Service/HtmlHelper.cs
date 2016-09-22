using HtmlAgilityPack;
using SyncfusionEbookDownloader.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionEbookDownloader.UI.Service
{
    public static class HtmlHelper
    {
        private static string _ebooksCollectionLink = "https://www.syncfusion.com/resources/techportal/ebooks";
        public static Task<IList<SyncfusionEbook>> ExtractAllEbooks()
        {
            return Task.Run<IList<SyncfusionEbook>>(() =>
            {
                HtmlWeb web = new HtmlWeb();
                HtmlDocument document = web.Load(_ebooksCollectionLink);

                IList<HtmlNode> nodes = document.DocumentNode.SelectNodes("//div[contains(@class, 'list-details')]");

                IList<SyncfusionEbook> ebooks = new List<SyncfusionEbook>(nodes.Count);

                foreach (var node in nodes)
                {
                    string imagePath = "https:" + node.Descendants("img").First().Attributes["data-original"].Value;
                    string title = node.Descendants("a").ElementAt(1).InnerText.Trim();
                    string author = node.Descendants("div").Last().InnerText.Trim();

                    ebooks.Add(new SyncfusionEbook { Image = imagePath, Title = title, Author = author });
                }

                return ebooks;
            });
        }
    }
}
