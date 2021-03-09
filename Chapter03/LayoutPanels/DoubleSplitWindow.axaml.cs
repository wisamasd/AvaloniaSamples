using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LayoutPanels
{
    public class DoubleSplitWindow : Window
    {
        public DoubleSplitWindow()
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
