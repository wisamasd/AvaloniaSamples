using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Controls
{
    public class ButtonsWithContent : Window
    {
        public ButtonsWithContent()
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
