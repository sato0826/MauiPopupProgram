using CommunityToolkit.Maui.Views;
using MauiPopupSampleProgram.ViewModels.Common;

namespace MauiPopupSampleProgram.Views.Components;

public partial class PopupPicker : CommunityToolkit.Maui.Views.Popup
{
    private readonly PopupPickerViewModel vm;

    public PopupPicker(List<DropdownItem> dropdownItems, DropdownItem? selectedItem)
    {
		InitializeComponent();
        this.vm = new PopupPickerViewModel(dropdownItems, selectedItem);
        BindingContext = this.vm;

    }

    private async void Popup_Opened(object sender, CommunityToolkit.Maui.Core.PopupOpenedEventArgs e)
    {
        if (this.vm.SelectedItem != null)
        {
            await Task.Delay(150); // Delay to ensure the CollectionView is fully rendered

            dropdownCollectionView.ScrollTo(vm.SelectedItem, ScrollToPosition.Start, animate: false);
        }
    }

    private async void Label_Tapped(object sender, TappedEventArgs e)
    {
        var label = (Label)sender;
        var selectedItem = (DropdownItem)label.BindingContext;
        this.vm.UpdateSelectedItem(selectedItem);

        var cts = new CancellationTokenSource(TimeSpan.FromSeconds(5));
        await CloseAsync(vm.Items, cts.Token);
    }
}