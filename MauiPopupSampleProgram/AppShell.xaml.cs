using MauiPopupSampleProgram.Views;

namespace MauiPopupSampleProgram
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("NewPage1", typeof(NewPage1));
        }
    }
}
