using CommunityToolkit.Mvvm.ComponentModel;
using MauiPopupSampleProgram.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPopupSampleProgram.ViewModels
{
    public partial class SearchViewModel : ObservableObject, INotifyPropertyChanged
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(FromDisplay))]
        private DateTime? _from;

        public string FromDisplay => From.ToString();

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(ToDisplay))]
        private DateTime? _to;

        public string ToDisplay => To.ToString();

        [ObservableProperty]
        private List<DropdownItem> _statusSearchItems = new List<DropdownItem> {    
            //dummyData
            new DropdownItem { Text = "Item1" },
            new DropdownItem { Text = "Item2"},
            new DropdownItem { Text = "Item3" }
        };

        [ObservableProperty]
        private DropdownItem _selectedStatusSearchItem;
    }
}
