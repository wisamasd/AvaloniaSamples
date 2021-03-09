using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace NonCompiledXaml
{
    public class Window1 : Window
    {
        private Button button1;

        public Window1(string xamlFile)
        {
            InitializeComponent(xamlFile);
        }

        private void InitializeComponent(string xamlFile)
        {
            this.Width = this.Height = 285;
            //this.Left = this.Top = 100;
            this.Title = "Dynamically Loaded XAML";

            // Get the XAML content from an external file.
            AvaloniaObject rootElement = (AvaloniaObject) AvaloniaXamlLoader.Load();

            // Insert the markup into this window.
            this.Content = rootElement;

            // Find the control with the appropriate name.
            //button1 = (Button)LogicalTreeHelper.FindLogicalNode(rootElement, "button1");
            button1 = this.FindControl<Button>("button1");

            // Wire up the event handler.
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            button1.Content = "Thank you.";
        }
    }
}
