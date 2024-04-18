using System.Collections.Specialized;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ToRedOnHover(object sender, RoutedEventArgs e)
        {
            ToRed.Background = Brushes.Red;
            ToPurple.Background = Brushes.Red;
            ToWhite.Background = Brushes.Red;
        }

        private void ToPurpleOnPress(object sender, RoutedEventArgs e)
        {
            ToRed.Background = Brushes.Purple;
            ToPurple.Background = Brushes.Purple;
            ToWhite.Background = Brushes.Purple;
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            ToRed.Background = Brushes.White;
            ToPurple.Background = Brushes.White;
            ((Button)sender).Background = Brushes.White;
        }
        
        private void OnMouseUp(object sender, MouseButtonEventArgs e)
        {
            ToRed.Background = Brushes.Black;
            ToPurple.Background = Brushes.Black;
            ((Button)sender).Background = Brushes.Black;
        }
    }
}