using System.Windows;
using System.Windows.Input;

namespace WpfApp4.kullanıcıkosullari
{
    /// <summary>
    /// Interaction logic for iptalveiade.xaml
    /// </summary>
    public partial class iptalveiade : Window
    {
        public iptalveiade()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.WindowState = System.Windows.WindowState.Maximized;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.ticimax.com/");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            scrollviewer.ScrollToVerticalOffset(0);
        }

        private void facebook_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/bambionline");
        }

        private void Twitter_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/bambiayakkabi");
        }

        private void instagram_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/bambiayakkabi/");
        }


        private void arama_Click(object sender, RoutedEventArgs e)
        {
            if (aramaborderi.Visibility == Visibility.Visible)
            {
                aramaborderi.Visibility = Visibility.Hidden;
                uyeyerigrid.Visibility = Visibility.Visible;
            }
            else if (aramaborderi.Visibility == Visibility.Hidden)
            {
                aramaborderi.Visibility = Visibility.Visible;
                uyeyerigrid.Visibility = Visibility.Hidden;
            }

        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            sepetimborder.Visibility = Visibility.Visible;
            uyeyerigrid.Visibility = Visibility.Hidden;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            sepetimborder.Visibility = Visibility.Hidden;
            uyeyerigrid.Visibility = Visibility.Visible;
        }

        private void erkekbut_MouseEnter(object sender, MouseEventArgs e)
        {
            erkekkategori.Visibility = Visibility.Visible;
        }
        private void erkekbut_MouseLeave_1(object sender, MouseEventArgs e)
        {
            erkekkategori.Visibility = Visibility.Hidden;
        }

        private void kadinkategori_MouseEnter(object sender, MouseEventArgs e)
        {
            kadinkategori.Visibility = Visibility.Visible;
        }

        private void kadinkategori_MouseLeave(object sender, MouseEventArgs e)
        {
            kadinkategori.Visibility = Visibility.Hidden;
        }
        private void kullanımsart_Click(object sender, RoutedEventArgs e)
        {
            Window window = new Page1();
            window.Show();
            this.Close();
        }

        private void iletisim_Click(object sender, RoutedEventArgs e)
        {
            Window window = new iletisim();
            window.Show();
            this.Close();
        }

        private void hakkimizda_Click(object sender, RoutedEventArgs e)
        {
            Window window = new hakkimizda();
            window.Show();
            this.Close();
        }

        private void gizlilikguven_Click(object sender, RoutedEventArgs e)
        {
            Window window = new gizlilikguvenlik();
            window.Show();
            this.Close();
        }

        private void iptaliadekosul_Click(object sender, RoutedEventArgs e)
        {
            Window window = new iptalveiade();
            window.Show();
            this.Close();
        }

        private void islemrehberi_Click(object sender, RoutedEventArgs e)
        {
            Window window = new islemrehberi();
            window.Show();
            this.Close();
        }

        private void guvenlialisveris_Click(object sender, RoutedEventArgs e)
        {
            Window window = new guvenlialisveris();
            window.Show();
            this.Close();
        }

        private void siparislerim_Click(object sender, RoutedEventArgs e)
        {
            Window window = new siparislerim();
            window.Show();
            this.Close();
        }

        private void alisverissepetim_Click(object sender, RoutedEventArgs e)
        {
            Window window = new sepetim();
            window.Show();
            this.Close();
        }
    }
}
