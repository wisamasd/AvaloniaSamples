using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace LayoutPanels
{
    public class SimpleInkCanvas : Window
    {
        public SimpleInkCanvas()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif

            //foreach (InkCanvasEditingMode mode in Enum.GetValues(typeof(InkCanvasEditingMode)))
            //{
            //    lstEditingMode.Items.Add(mode);
            //    lstEditingMode.SelectedItem = inkCanvas.EditingMode;
            //}
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
