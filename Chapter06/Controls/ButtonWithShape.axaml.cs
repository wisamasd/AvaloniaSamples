using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Controls
{
    public class ButtonWithShape : Window
    {
        public ButtonWithShape()
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
