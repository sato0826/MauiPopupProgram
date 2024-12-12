using CommunityToolkit.Maui.Views;
using MauiPopupSampleProgram.ViewModels.Common;

namespace MauiPopupSampleProgram.Views.Components;

public partial class PopupCalendar : Popup
{
    private readonly PopupCalendarViewModel vm;

    public PopupCalendar(DateTime date)
    {
        InitializeComponent();

        DateTime initialDate = date == DateTime.MinValue ? DateTime.Today : date;
        vm = new PopupCalendarViewModel(this, initialDate);
        BindingContext = vm;
    }

    public PopupCalendar(DateTime? date)
    {
        InitializeComponent();

        DateTime initialDate = date ?? DateTime.Today;
        vm = new PopupCalendarViewModel(this, initialDate);
        BindingContext = vm;
    }
}