using SyncfusionEbookDownloader.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionEbookDownloader.UI.Service
{
    public interface ISyncfusionEbookService
    {
        Task<IList<SyncfusionEbook>> GetAllEbooks();

        Task<SyncfusionEbook> GetEbookDetails();
    }
}
