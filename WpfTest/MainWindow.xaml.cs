using System.ComponentModel;
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

namespace WpfTest
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

        private void Classic_Click(object sender, RoutedEventArgs e)
        {
            var Classic = new Classic();
            Classic.Show();
        }

        private void Filter_Click(object sender, RoutedEventArgs e)
        {
            var Filter = new Filter();
            Filter.Show();
        }
    }
}