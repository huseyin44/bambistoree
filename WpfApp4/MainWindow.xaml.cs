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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using WpfApp4.kullanımkosulları;
using WpfApp4.KullanımSartları;


namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window 
    {
        DispatcherTimer timer;
        int i = 0;
        TimeSpan zaman;

        public MainWindow()
        {
            InitializeComponent();
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 2);
            timer.Tick += new EventHandler(timer_Tick);
            timer.IsEnabled = true;

            zaman = TimeSpan.FromSeconds(55265);
            timer = new DispatcherTimer(new TimeSpan(0, 0, 1), DispatcherPriority.Normal, delegate
            {
                sayac.Text = zaman.ToString("c");
                sayac1.Text = zaman.ToString("c");
                if (zaman == TimeSpan.Zero) timer.Stop();
                zaman = zaman.Add(TimeSpan.FromSeconds(-1));
            }, Application.Current.Dispatcher);
            timer.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            i++;
            if (i > 5)
            {
                i = 1;
            }
            SlideShow(i);
        }
        private void SlideShow(int i)
        {
            BitmapImage image = new BitmapImage();
            image.BeginInit();
            string filename = ((i < 10) ? "slide/sl0" + i + ".jpg" : "slide/sl" + i + ".jpg");
            image.UriSource = new Uri(filename, UriKind.Relative);
            image.EndInit();
            slide.Source = image;
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

        private void twitter_Click(object sender, RoutedEventArgs e)
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
            Page page = new Page1();
            this.Content = page;
        }

        private void iletisim_Click(object sender, RoutedEventArgs e)
        {
            Page page = new iletisimsayfasi();
            this.Content = page;
        }

        private void hakkimizda_Click(object sender, RoutedEventArgs e)
        {
            Page page = new hakkimizda();
            this.Content = page;
        }

        private void gizlilikguven_Click(object sender, RoutedEventArgs e)
        {
            Page page = new gizililikguvenlik();
            this.Content = page;
        }

        private void iptaliadekosul_Click(object sender, RoutedEventArgs e)
        {
            Page page = new iptalveiade();
            this.Content = page;
        }

        private void islemrehberi_Click(object sender, RoutedEventArgs e)
        {
            Page page = new islemrehberi();
            this.Content = page;
        }

        private void guvenlialisveris_Click(object sender, RoutedEventArgs e)
        {
            Page page = new guvenlialisveris();
            this.Content = page;
        }

        private void siparislerim_Click(object sender, RoutedEventArgs e)
        {
            Page page = new siparislerim();
            this.Content = page;
        }

        private void alisverissepetim_Click(object sender, RoutedEventArgs e)
        {
                Page page = new sepetim();
                this.Content = page;
        }
    }
}  

       
    