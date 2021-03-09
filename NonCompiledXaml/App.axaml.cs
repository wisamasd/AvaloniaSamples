using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;

namespace NonCompiledXaml
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            // First approach: window with XAML content.
            Window1 window1 = new Window1("Window1.axaml");
            window1.Show();
        }
    }
}
