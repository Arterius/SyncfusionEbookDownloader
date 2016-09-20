using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionEbookDownloader.UI.Model
{
    public class SyncfusionEbook
    {
        public string Image { get; set; }
        public string Author { get; set; }
        public string Title { get; set; }
        public string DownloadLink { get; set; }
        public int Pages { get; set; }
        public string Description { get; set; }
        public string TableOfContents { get; set; }
    }
}
