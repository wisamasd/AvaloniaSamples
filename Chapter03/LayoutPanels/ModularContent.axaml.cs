using Avalonia;
using Avalonia.Controls;
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
        }

        private void chk_Checked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = (CheckBox)e.OriginalSource;
            DependencyObject obj = LogicalTreeHelper.FindLogicalNode(this, chk.Content.ToString());
            ((FrameworkElement)obj).Visibility = Visibility.Visible;
        }

        private void chk_Unchecked(object sender, RoutedEventArgs e)
        {
            CheckBox chk = (CheckBox)e.OriginalSource;
            DependencyObject obj = LogicalTreeHelper.FindLogicalNode(this, chk.Content.ToString());
            ((FrameworkElement)obj).Visibility = Visibility.Collapsed;
        }
    }
}
