using MauiPopupSampleProgram.ViewModels.Common;
using MauiPopupSampleProgram.Views.Components;
using CommunityToolkit.Maui.Views;
using MauiPopupSampleProgram.ViewModels;


namespace MauiPopupSampleProgram.Views;

public partial class NewPage1 : ContentPage
{
    private SearchViewModel ViewModel { get; }

    public NewPage1()
	{
		InitializeComponent();
        ViewModel = new SearchViewModel();
        BindingContext = ViewModel;
    }

    private async void DateButtonFrom_Clicked(object sender, EventArgs e)
    {
        var popup = new PopupCalendar(ViewModel.From);
        // popup instance create
        var result = await this.ShowPopupAsync(popup);

        // popup show
        if (result is DateTime selectedDate)
        {
            ViewModel.From = selectedDate;
        }
    }

    private async void DateButtonTo_Clicked(object sender, EventArgs e)
    {
        var popup = new PopupCalendar(ViewModel.To);
        // popup instance create
        var result = await this.ShowPopupAsync(popup);

        // popup show
        if (result is DateTime selectedDate)
        {
            ViewModel.To = selectedDate;
        }
    }

    private async void PickerButtonStatus_Clicked(object sender, EventArgs e)
    {
        // popup instance create
        var popup = new PopupPicker(ViewModel.StatusSearchItems, ViewModel.SelectedStatusSearchItem);
        // popup show
        var result = await this.ShowPopupAsync(popup);

        if (result is List<DropdownItem> prefecture)
        {
            ViewModel.StatusSearchItems = prefecture;
            ViewModel.SelectedStatusSearchItem = prefecture.FirstOrDefault(x => x.IsSelected);
        }
    }
}