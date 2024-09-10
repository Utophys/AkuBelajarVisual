using Avalonia.Controls; 
using Avalonia.Interactivity;
using MsBox.Avalonia;


namespace AkuBelajarVisual
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object? sender, RoutedEventArgs e)
        {
            var usernameTextBox = this.FindControl<TextBox>("UsernameTextBox");
            var passwordBox = this.FindControl<TextBox>("PasswordBox");

            if (usernameTextBox != null && passwordBox != null)
            {
                var username = usernameTextBox.Text;
                var password = passwordBox.Text;

                MessageBoxManager
                    .GetMessageBoxStandard("Form Data", $"Username: {username}\nPassword: {password}")
                    .ShowAsync();
            }
            else
            {
                MessageBoxManager
                    .GetMessageBoxStandard("Error", "One or more controls could not be found.")
                    .ShowAsync();
            }
        }
    }
}
