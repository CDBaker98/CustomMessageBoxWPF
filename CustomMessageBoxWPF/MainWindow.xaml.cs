using System.Windows;

namespace CustomMessageBox {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private void btnOkInfo_Click(object sender, RoutedEventArgs e) {
            _ = new MessageBoxCustom($"Informational popup from the application.", MessageType.Info, MessageButtons.Ok).ShowDialog();
        }
        private void btnOkWarning_Click(object sender, RoutedEventArgs e) {
            _ = new MessageBoxCustom("Warning message from the application.", MessageType.Warning, MessageButtons.Ok).ShowDialog();
        }
        private void btnOkError(object sender, RoutedEventArgs e) {
            _ = new MessageBoxCustom("Error message from the application.", MessageType.Error, MessageButtons.Ok).ShowDialog();
        }
        private void btnOkSuccessClick(object sender, RoutedEventArgs e) {
            _ = new MessageBoxCustom("Operation completed successfully!", MessageType.Success, MessageButtons.Ok).ShowDialog();
        }
        private void btnOkCancel_Click(object sender, RoutedEventArgs e) {
            _ = new MessageBoxCustom("Here, you can select OK or Cancel.", MessageType.Confirmation, MessageButtons.OkCancel).ShowDialog();
        }
        private void btnYesNo_Click(object sender, RoutedEventArgs e) {
            _ = new MessageBoxCustom("Here, you can select Yes or No.", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e) {
            bool? Result = new MessageBoxCustom("Are you sure, You want to close application?", MessageType.Confirmation, MessageButtons.YesNo).ShowDialog();
            if (Result.Value) {
                Application.Current.Shutdown();
            }
        }
    }
}
