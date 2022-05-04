using System.Windows;
using System.Windows.Media;

namespace CustomMessageBox {
    /// <summary>
    /// Interaction logic for MessageBoxCustom.xaml
    /// </summary>
    public partial class MessageBoxCustom : Window {
        public MessageBoxCustom(string Message, MessageType Type, MessageButtons Buttons) {
            InitializeComponent();

            txtMessage.Text = Message;

            switch (Type) {
                case MessageType.Info:
                    txtTitle.Text = "Info";
                    break;
                case MessageType.Confirmation:
                    txtTitle.Text = "Confirmation";
                    break;
                case MessageType.Success:
                    ChangeBackgroundThemeColor(Colors.Green);
                    txtTitle.Text = "Success";
                    break;
                case MessageType.Warning:
                    txtTitle.Text = "Warning";
                    break;
                case MessageType.Error:
                    ChangeBackgroundThemeColor(Colors.Red);
                    txtTitle.Text = "Error";
                    break;
                default:
                    break;
            }

            switch (Buttons) {
                case MessageButtons.Ok:
                    btnOk.Visibility = Visibility.Visible;
                    btnCancel.Visibility = Visibility.Collapsed;
                    btnYes.Visibility = Visibility.Collapsed; btnNo.Visibility = Visibility.Collapsed;
                    break;
                case MessageButtons.OkCancel:
                    btnYes.Visibility = Visibility.Collapsed; btnNo.Visibility = Visibility.Collapsed;
                    break;
                case MessageButtons.YesNo:
                    btnOk.Visibility = Visibility.Collapsed; btnCancel.Visibility = Visibility.Collapsed;
                    break;
                default:
                    break;
            }
        }

        public void ChangeBackgroundThemeColor(Color newColor) {
            cardHeader.Background = new SolidColorBrush(newColor);
            btnClose.Foreground = new SolidColorBrush(newColor);

            btnOk.Background = new SolidColorBrush(newColor);
            btnCancel.Background = new SolidColorBrush(newColor);
            btnYes.Background = new SolidColorBrush(newColor);
            btnNo.Background = new SolidColorBrush(newColor);
        }

        private void btnOk_Click(object sender, RoutedEventArgs e) {
            DialogResult = true;
            Close();
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e) {
            DialogResult = false;
            Close();
        }
        private void btnYes_Click(object sender, RoutedEventArgs e) {
            DialogResult = true;
            Close();
        }
        private void btnNo_Click(object sender, RoutedEventArgs e) {
            DialogResult = false;
            Close();
        }
        private void btnClose_Click(object sender, RoutedEventArgs e) {
            DialogResult = false;
            Close();
        }
    }

    public enum MessageType {
        Info,
        Confirmation,
        Success,
        Warning,
        Error,
    }
    public enum MessageButtons {
        OkCancel,
        YesNo,
        Ok,
    }
}
