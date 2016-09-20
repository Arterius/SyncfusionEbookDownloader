using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SyncfusionEbookDownloader.UI.Service;
using SyncfusionEbookDownloader.UI.Model;
using System.Collections.ObjectModel;
using GalaSoft.MvvmLight.CommandWpf;

namespace SyncfusionEbookDownloader.UI.ViewModel
{
    public class MainWindowViewModel
    {
        private readonly ISyncfusionEbookService _syncfusionEbookService;
        public ObservableCollection<SyncfusionEbook> EbooksCollection { get; set; }

        private RelayCommand _fetchEbooksCommand;
        public RelayCommand FetchEbooksCommand
        {
            get
            {
                return _fetchEbooksCommand ?? (_fetchEbooksCommand = new RelayCommand(FetchEbooks));
            }
        }

        public MainWindowViewModel(ISyncfusionEbookService syncfusionEbookService)
        {
            _syncfusionEbookService = syncfusionEbookService;
            EbooksCollection = new ObservableCollection<SyncfusionEbook>();
        }

        private async void FetchEbooks()
        {
            IList<SyncfusionEbook> ebooks = await _syncfusionEbookService.GetAllEbooks();

            foreach (var ebook in ebooks)
            {
                EbooksCollection.Add(ebook);
            }
        }
    }
}
