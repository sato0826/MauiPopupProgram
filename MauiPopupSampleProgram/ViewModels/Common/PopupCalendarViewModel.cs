using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace MauiPopupSampleProgram.ViewModels.Common
{
    public partial class PopupCalendarViewModel : ObservableObject
    {
        private readonly Popup popup;

        [ObservableProperty]
        private DateTime _selectedDate = DateTime.Now;
        public CultureInfo Culture => new CultureInfo("ja-JP");

        public PopupCalendarViewModel(Popup popup, DateTime date)
        {
            this.popup = popup;
            _selectedDate = date;
        }

        [RelayCommand]
        private void TapDay(DateTime date)
        {
            popup.Close(date);
        }
    }
}
