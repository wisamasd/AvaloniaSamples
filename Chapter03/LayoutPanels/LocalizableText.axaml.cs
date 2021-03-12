using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace LayoutPanels
{
    public class LocalizableText : Window
    {
        private Button cmdPrev;
        private Button cmdNext;

        public LocalizableText()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            cmdPrev = this.FindControl<Button>("cmdPrev");
            cmdNext = this.FindControl<Button>("cmdNext");
        }

        private void chkLongText_Checked(object sender, RoutedEventArgs e)
        {
            cmdPrev.Content = " <- Go to the Previous Window ";
            cmdNext.Content = " Go to the Next Window -> ";
        }

        private void chkLongText_Unchecked(object sender, RoutedEventArgs e)
        {
            cmdPrev.Content = "Prev";
            cmdNext.Content = "Next";
        }
    }
}
