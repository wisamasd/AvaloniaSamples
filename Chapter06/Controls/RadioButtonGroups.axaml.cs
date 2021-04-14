using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Controls
{
    public class RadioButtonGroups : Window
    {
        public RadioButtonGroups()
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
