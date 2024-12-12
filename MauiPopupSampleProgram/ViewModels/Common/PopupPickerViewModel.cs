using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPopupSampleProgram.ViewModels.Common
{
    public partial class PopupPickerViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<DropdownItem> _items;

        [ObservableProperty]
        private DropdownItem? _selectedItem;

        public PopupPickerViewModel(List<DropdownItem> items, DropdownItem? selectedItem)
        {
            _items = items;
            _selectedItem = selectedItem;
        }

        public void UpdateSelectedItem(DropdownItem selectedItem)
        {
            SelectedItem = selectedItem;

            foreach (var item in Items)
            {
                item.IsSelected = item == selectedItem;
            }
            OnPropertyChanged(nameof(Items));
        }
    }
}
