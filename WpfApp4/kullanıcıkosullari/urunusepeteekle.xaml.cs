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
using WpfApp4.usercontrollers;

namespace WpfApp4.kullanıcıkosullari
{
    /// <summary>
    /// Interaction logic for urunusepeteekle.xaml
    /// </summary>
    public partial class urunusepeteekle : Window
    {
        public urunusepeteekle()
        {
            InitializeComponent();
            MainWindow main = new MainWindow();          
            if (main.uyeyeri44.Visibility == Visibility.Visible && main.uyeyerigrid.Visibility == Visibility.Hidden)
            {
                uyeyerigrid.Visibility = Visibility.Hidden;
                uyeyeri44.Visibility = Visibility.Visible;

            }
            else
            {
                uyeyerigrid.Visibility = Visibility.Visible;
                uyeyeri44.Visibility = Visibility.Hidden;
            }

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
            uyegirisi uygrs = new uyegirisi();
            Page1 main = new Page1();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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

        private void iletisim_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            iletisim main = new iletisim();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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

        private void hakkimizda_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            hakkimizda main = new hakkimizda();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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

        private void gizlilikguven_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            gizlilikguvenlik main = new gizlilikguvenlik();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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

        private void iptaliadekosul_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            iptalveiade main = new iptalveiade();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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

        private void islemrehberi_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            islemrehberi main = new islemrehberi();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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

        private void guvenlialisveris_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            guvenlialisveris main = new guvenlialisveris();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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

        private void siparislerim_Click(object sender, RoutedEventArgs e)
        {
            Window window = new siparislerim();
            window.Show();
            this.Close();

        }

        private void alisverissepetim_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepetim main = new sepetim();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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

        private void anasayfa_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            MainWindow main = new MainWindow();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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



        private void siparistakip_Click_(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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

        private void uyegirisi_Click(object sender, RoutedEventArgs e)
        {

            Window window = new uyegirisi();
            window.Show();
            this.Close();

        }

        private void cikisyap_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.uyeyerigrid.Visibility = Visibility.Visible;
            main.uyeyeri44.Visibility = Visibility.Hidden;
            main.Show();
            this.Close();
        }

        private void urunozellikleri_Click(object sender, RoutedEventArgs e)
        {         
            UrunOzellikleri user = new UrunOzellikleri();           
            griduser.Children.Clear();
            griduser.Children.Add(user);
        }

        private void odemesecenek_Click(object sender, RoutedEventArgs e)
        {
            odemesecenekleri user = new odemesecenekleri();
            user.kredikartifiyati.Content = labe3.Text;
            griduser.Children.Clear();
            griduser.Children.Add(user);
        }

        private void yorumlar_Click(object sender, RoutedEventArgs e)
        {
            UserControlYorumlar user = new UserControlYorumlar();
            griduser.Children.Clear();
            griduser.Children.Add(user);
        }

        private void iptal44_Click(object sender, RoutedEventArgs e)
        {
            Useriptal user = new Useriptal();
            griduser.Children.Clear();
            griduser.Children.Add(user);
        }

        private void favoriekle_Click(object sender, RoutedEventArgs e)
        {       
            MessageBox.Show("Ürün favorilerinize eklenmiştir.");           
            favoriekle2.Visibility = Visibility.Visible;
            favoriekle.Visibility = Visibility.Hidden;
        }
        private void favoriekle2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ürün favorilerinizden çıkartılmıştır.");
            favoriekle2.Visibility = Visibility.Hidden;
            favoriekle.Visibility = Visibility.Visible;
        }
        private void fiyatdusunce_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ürün fiyat alarm listenize eklendi.");
            fiyatdusunce.Visibility = Visibility.Hidden;
            fiyatdusunce2.Visibility = Visibility.Visible;
        }
        private void fiyatdusunce2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Ürün fiyat alarm listenizden çıkarıldı.");
            fiyatdusunce.Visibility = Visibility.Visible;
            fiyatdusunce2.Visibility = Visibility.Hidden;
        }

        private void sepeteekle_Click(object sender, RoutedEventArgs e)
        {       
            urunsepeteekleekrani ekran = new urunsepeteekleekrani();
            double x = Convert.ToDouble(combobox.SelectedIndex);            
            ekran.bambi.Content = labe1.Content;
            ekran.isim.Content = labe2.Content;
            ekran.fiyat2.Content = labe3.Text;
            ekran.renk2.Content = butonrengi.Content;
            ekran.kirmizifiyat.Content = texblock.Text;
            ekran.image.Source = image2.Source;
            double a = Convert.ToDouble(labe3.Text) * x;
            double b = Convert.ToDouble(texblock.Text) * x;
            double c = b - a;
            ekran.borderfiyat5.Content = c.ToString();
            ekran.borderfiyat4.Content = a.ToString();
            ekran.borderfiyat6.Content = b.ToString();
            ekran.indirimfiyati.Content = (c * -1).ToString();
            ekran.combobox2.SelectedIndex = combobox.SelectedIndex;

            
            
            if (buttonclick==true)
            {                              
                ekran.beden2.Content = bt1.Content;
                buttonclick36 = false;
                buttonclick37 = false;
                buttonclick38 = false;
                buttonclick39 = false;
                buttonclick40 = false;
                buttonclick = false;
            }
            else if (buttonclick36 == true)
            {
                ekran.beden2.Content = bt2.Content;
                buttonclick = false;
                buttonclick37 = false;
                buttonclick38 = false;
                buttonclick39 = false;
                buttonclick40 = false;
                buttonclick36 = false;
            }
            else if (buttonclick37 == true)
            {
                ekran.beden2.Content = bt3.Content;
                buttonclick = false;
                buttonclick36 = false;
                buttonclick38 = false;
                buttonclick39 = false;
                buttonclick40 = false;
                buttonclick37 = false;
            }
            else if (buttonclick38 == true)
            {
                ekran.beden2.Content = bt4.Content;
                buttonclick = false;
                buttonclick37 = false;
                buttonclick36 = false;
                buttonclick39 = false;
                buttonclick40 = false;
                buttonclick38 = false;
            }
            else if (buttonclick39 == true)
            {
                ekran.beden2.Content = bt5.Content;
                buttonclick = false;
                buttonclick37 = false;
                buttonclick38 = false;
                buttonclick36 = false;
                buttonclick40 = false;
                buttonclick39 = false;
            }
            else if (buttonclick40 == true)
            {
                ekran.beden2.Content = bt6.Content;
                buttonclick = false;
                buttonclick37 = false;
                buttonclick38 = false;
                buttonclick39 = false;
                buttonclick36 = false;
                buttonclick40 = false;
            }
            ekran.ShowDialog();
        }

        private void imageyanakaydir_Click(object sender, RoutedEventArgs e)
        {
            image2.Source = image0.Source;
        }
        private void imageyanakaydir1_Click(object sender, RoutedEventArgs e)
        {
            image2.Source = image1.Source;
        }
        private bool buttonclick = false;
        private bool buttonclick36 = false;
        private bool buttonclick37 = false;
        private bool buttonclick38 = false;
        private bool buttonclick39 = false;
        private bool buttonclick40 = false;
        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            urunsepeteekleekrani ekran = new urunsepeteekleekrani();
            bt1.Background = Brushes.Black;
            bt1.Foreground = Brushes.White;
            buttonclick = true;            
        }
        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            urunsepeteekleekrani ekran = new urunsepeteekleekrani();
            bt2.Background = Brushes.Black;
            bt2.Foreground = Brushes.White;
            buttonclick36 = true;
        }
        private void bt3_Click(object sender, RoutedEventArgs e)
        {
            urunsepeteekleekrani ekran = new urunsepeteekleekrani();
            bt3.Background = Brushes.Black;
            bt3.Foreground = Brushes.White;
            buttonclick37 = true;
        }
        private void bt4_Click(object sender, RoutedEventArgs e)
        {
            urunsepeteekleekrani ekran = new urunsepeteekleekrani();
            bt4.Background = Brushes.Black;
            bt4.Foreground = Brushes.White;
            buttonclick38 = true;
        }
        private void bt5_Click(object sender, RoutedEventArgs e)
        {
            urunsepeteekleekrani ekran = new urunsepeteekleekrani();
            bt5.Background = Brushes.Black;
            bt5.Foreground = Brushes.White;
            buttonclick39 = true;
        }
        private void bt6_Click(object sender, RoutedEventArgs e)
        {
            urunsepeteekleekrani ekran = new urunsepeteekleekrani();
            bt6.Background = Brushes.Black;
            bt6.Foreground = Brushes.White;
            buttonclick40 = true;
        }
        private void yenisezonkadin_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            YeniSezon main = new YeniSezon();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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



        private void yenisezonerkek_Click(object sender, RoutedEventArgs e)
        {
            yenisezonerkek main = new yenisezonerkek();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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

        private void Canta_Click(object sender, RoutedEventArgs e)
        {
            canta main = new canta();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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

        private void kadinbot_Click(object sender, RoutedEventArgs e)
        {
            kadinbot main = new kadinbot();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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

        private void kadincizme_Click(object sender, RoutedEventArgs e)
        {
            kadincizme main = new kadincizme();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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

        private void kadinsneak_Click(object sender, RoutedEventArgs e)
        {
            KadinSneaker main = new KadinSneaker();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
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

        private void buyukımage_Click(object sender, RoutedEventArgs e)
        {
            resimbuyutme user = new resimbuyutme();
            user.image444.Source = image2.Source;
            user.ShowDialog();
            

        }
    }
}
