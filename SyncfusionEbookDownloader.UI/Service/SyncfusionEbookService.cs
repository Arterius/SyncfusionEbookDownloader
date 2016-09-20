using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyncfusionEbookDownloader.UI.Model;

namespace SyncfusionEbookDownloader.UI.Service
{
    public class SyncfusionEbookService : ISyncfusionEbookService
    {
        public async Task<IList<SyncfusionEbook>> GetAllEbooks()
        {
            return await HtmlHelper.ExtractAllEbooks();
        }

        public Task<SyncfusionEbook> GetEbookDetails()
        {
            throw new NotImplementedException();
        }
    }
}
