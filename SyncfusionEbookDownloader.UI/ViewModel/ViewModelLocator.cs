using SyncfusionEbookDownloader.UI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SyncfusionEbookDownloader.UI.ViewModel
{
    public class ViewModelLocator
    {
        private static MainWindowViewModel _mainWindowViewModel;
        public static MainWindowViewModel MainWindowViewModelStatic
        {
            get
            {
                return _mainWindowViewModel ?? (_mainWindowViewModel = new MainWindowViewModel(new SyncfusionEbookService()));
            }
        }

    }
}
