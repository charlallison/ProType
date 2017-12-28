using Odyssey.Controls;
using Odyssey.Controls.Classes;

namespace ProType {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow {
        public MainWindow() {
            InitializeComponent();
            SkinManager.SkinId = SkinId.Windows7;
        }

        private void OfficeBlue(object sender, System.Windows.RoutedEventArgs e) {
            SkinManager.SkinId = SkinId.OfficeBlue;
        }

        private void OfficeBlack(object sender, System.Windows.RoutedEventArgs e) {
            SkinManager.SkinId = SkinId.OfficeBlack;
        }

        private void Windows7(object sender, System.Windows.RoutedEventArgs e) {
            SkinManager.SkinId = SkinId.Windows7;
        }

        private void Vista(object sender, System.Windows.RoutedEventArgs e) {
            SkinManager.SkinId = SkinId.Vista;
        }

        private void OfficeSilver(object sender, System.Windows.RoutedEventArgs e) {
            SkinManager.SkinId = SkinId.OfficeSilver;
        }
    }
}
