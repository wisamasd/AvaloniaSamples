using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace LayoutPanels
{
    public class ModularContent : Window
    {
        public ModularContent()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            AddHandler(CheckBox.CheckedEvent, chk_Checked);
            AddHandler(CheckBox.UncheckedEvent, chk_Unchecked);
        }

        private void chk_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = (CheckBox)e.Source;
            StackPanel obj = this.FindControl<StackPanel>(chk.Content.ToString());
            obj.IsVisible = true;
        }

        private void chk_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = (CheckBox)e.Source;
            StackPanel obj = this.FindControl<StackPanel>(chk.Content.ToString());
            obj.IsVisible = false;
        }
    }
}
