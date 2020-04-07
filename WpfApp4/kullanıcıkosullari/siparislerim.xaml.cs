using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp4.kullanıcıkosullari
{
    /// <summary>
    /// Interaction logic for siparislerim.xaml
    /// </summary>
    public partial class siparislerim : Window
    {
        public siparislerim()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Maximized;
        }

        private void anasayfa_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            MainWindow main = new MainWindow();
            if (main.uyeyeri44.Visibility == Visibility.Visible && main.uyeyerigrid.Visibility == Visibility.Hidden)
            {
                main.uyeyerigrid.Visibility = Visibility.Hidden;
                main.uyeyeri44.Visibility = Visibility.Visible;
                main.Show();
                this.Close();
            }
            else
            {
                main.Show();
                this.Close();
            }

        }
    }
}
