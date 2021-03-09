using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace EightBall
{
    public class MainWindow : Window
    {
        private TextBox txtQuestion;
        private TextBox txtAnswer;
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

            txtQuestion = this.FindControl<TextBox>("txtQuestion");
            txtAnswer = this.FindControl<TextBox>("txtAnswer");
        }

        private void cmdAnswer_Click(object sender, RoutedEventArgs e)
        {
            // Dramatic delay...
            //this.Cursor = Cursors.Wait;
            System.Threading.Thread.Sleep(TimeSpan.FromSeconds(1));

            AnswerGenerator generator = new AnswerGenerator();
            txtAnswer.Text = generator.GetRandomAnswer(txtQuestion.Text);
            //this.Cursor = null;
        }
    }
}
