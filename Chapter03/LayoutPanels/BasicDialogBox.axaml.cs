using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LayoutPanels
{
    public class BasicDialogBox : Window
    {
        public BasicDialogBox()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
