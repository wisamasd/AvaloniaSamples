using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Controls
{
    public class GdiTextRendering : Window
    {
        public GdiTextRendering()
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
