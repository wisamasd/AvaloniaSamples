using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Controls
{
    public class LabelTest : Window
    {
        public LabelTest()
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
