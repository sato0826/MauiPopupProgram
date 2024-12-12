
namespace MauiPopupSampleProgram.ViewModels.Common
{
    public class DropdownItem
    {
        public string Text { get; set; }
        public string Value { get; set; }
        public bool IsSelected { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
