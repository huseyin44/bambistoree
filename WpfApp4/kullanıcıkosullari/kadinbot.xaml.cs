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
    /// Interaction logic for kadinbot.xaml
    /// </summary>
    public partial class kadinbot : Window
    {
        public kadinbot()
        {
            InitializeComponent();
        }
        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            slider.Minimum = 20;
            slider.Maximum = 480;
            int dgr = Convert.ToInt32(e.NewValue);
            string deger = String.Format("{0} TL - 500 TL", dgr);
            this.sliderlabel.Content = deger;
        }
        private void Window_Loaded_1(object sender, RoutedEventArgs e)
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

        private void favoriekle_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle.Visibility = Visibility.Visible;
            sepeteeklee.Visibility = Visibility.Visible;
        }

        private void favoriekle_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle.Visibility = Visibility.Hidden;
            sepeteeklee.Visibility = Visibility.Hidden;
        }
        private void favoriekle1_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle.Visibility = Visibility.Visible;
            sepeteeklee.Visibility = Visibility.Visible;
        }

        private void favoriekle1_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle.Visibility = Visibility.Hidden;
            sepeteeklee.Visibility = Visibility.Hidden;
        }
        private void favoriekle2_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle2.Visibility = Visibility.Visible;
            sepeteeklee2.Visibility = Visibility.Visible;
        }

        private void favoriekle2_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle2.Visibility = Visibility.Hidden;
            sepeteeklee2.Visibility = Visibility.Hidden;
        }
        private void favoriekle3_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle3.Visibility = Visibility.Visible;
            sepeteeklee3.Visibility = Visibility.Visible;
        }

        private void favoriekle3_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle3.Visibility = Visibility.Hidden;
            sepeteeklee3.Visibility = Visibility.Hidden;
        }
        private void favoriekle4_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle4.Visibility = Visibility.Visible;
            sepeteeklee4.Visibility = Visibility.Visible;
        }

        private void favoriekle4_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle4.Visibility = Visibility.Hidden;
            sepeteeklee4.Visibility = Visibility.Hidden;
        }
        private void favoriekle5_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle5.Visibility = Visibility.Visible;
            sepeteeklee5.Visibility = Visibility.Visible;
        }

        private void favoriekle5_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle5.Visibility = Visibility.Hidden;
            sepeteeklee5.Visibility = Visibility.Hidden;
        }
        private void favoriekle6_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle6.Visibility = Visibility.Visible;
            sepeteeklee6.Visibility = Visibility.Visible;
        }

        private void favoriekle6_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle6.Visibility = Visibility.Hidden;
            sepeteeklee6.Visibility = Visibility.Hidden;
        }

        private void favoriekle7_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle7.Visibility = Visibility.Visible;
            sepeteeklee7.Visibility = Visibility.Visible;
        }

        private void favoriekle7_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle7.Visibility = Visibility.Hidden;
            sepeteeklee7.Visibility = Visibility.Hidden;
        }
        private void favoriekle8_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle8.Visibility = Visibility.Visible;
            sepeteeklee8.Visibility = Visibility.Visible;
        }

        private void favoriekle8_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle8.Visibility = Visibility.Hidden;
            sepeteeklee8.Visibility = Visibility.Hidden;
        }
        private void favoriekle9_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle9.Visibility = Visibility.Visible;
            sepeteeklee9.Visibility = Visibility.Visible;
        }

        private void favoriekle9_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle9.Visibility = Visibility.Hidden;
            sepeteeklee9.Visibility = Visibility.Hidden;
        }
        private void favoriekle10_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle10.Visibility = Visibility.Visible;
            sepeteeklee10.Visibility = Visibility.Visible;
        }

        private void favoriekle10_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle10.Visibility = Visibility.Hidden;
            sepeteeklee10.Visibility = Visibility.Hidden;
        }
        private void favoriekle11_MouseEnter(object sender, MouseEventArgs e)
        {
            favoriekle11.Visibility = Visibility.Visible;
            sepeteeklee11.Visibility = Visibility.Visible;
        }

        private void favoriekle11_MouseLeave(object sender, MouseEventArgs e)
        {
            favoriekle11.Visibility = Visibility.Hidden;
            sepeteeklee11.Visibility = Visibility.Hidden;
        }

        private void favoriekle_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle2_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle3_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle4_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle5_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle6_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle7_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle8_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle9_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle10_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }
        }
        private void favoriekle11_Click(object sender, RoutedEventArgs e)
        {
            uyegirisi uygrs = new uyegirisi();
            sepeteekle main = new sepeteekle();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                MessageBox.Show("Ürün favorilerinize eklenmiştir.");
            }
            else
            {
                uygrs.Show();
                this.Close();
            }

        }

        private void sepeteeklee_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "OLİVİE";
            urunusepet.image0.Source = image444.Source;
            urunusepet.image2.Source = image444.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri("/images/olive-bot-k0777032103-9379 - Kopya.", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "BAMBİ";
            urunusepet.labe2.Content = "Olive-bot-k0777032103-93795";
            urunusepet.labe3.Text = label1.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati1.Text;
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }
        private void sepeteeklee2_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "OLİVE";
            urunusepet.image0.Source = image445.Source;
            urunusepet.image2.Source = image445.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"images/caterpillar-dark-olive-bot-k0111118401-3965 - Kopya.", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "BAMBİ";
            urunusepet.labe2.Content = "Caterpillar-dark-olive-bot-k0111118401-3965";
            urunusepet.labe3.Text = label2.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati2.Text;
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }
        private void sepeteeklee3_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "BEYAZ";
            urunusepet.image0.Source = image446.Source;
            urunusepet.image2.Source = image446.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"images/adc19515-23f4-413a-bcbb-b811023b3fa6 - Kopya.", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "BAMBİ";
            urunusepet.labe2.Content = "BEYAZ KADIN BOT L0806100009";
            urunusepet.labe3.Text = label3.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati3.Text;
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }
        private void sepeteeklee4_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "SİYAH";
            urunusepet.image0.Source = image447.Source;
            urunusepet.image2.Source = image447.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"images/images/harley-davidson-black-bot-k0777009603-1694.", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "BAMBİ";
            urunusepet.labe2.Content = "BLACK BAYAN BOT K0777009603";
            urunusepet.labe3.Text = label4.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati4.Text;
            UrunOzellikleri ozellik = new UrunOzellikleri();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }
        private void sepeteeklee5_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "SUNDANCE";
            urunusepet.image0.Source = image448.Source;
            urunusepet.image2.Source = image448.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"images/caterpillar-sundance-bot-k0111000101-93ec.", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "SUNDANCE";
            urunusepet.labe2.Content = "SUNDANCE BAYAN BOT K0111000101";
            urunusepet.labe3.Text = label5.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati5.Text;
            UrunOzellikleri ozellik = new UrunOzellikleri();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }
        private void sepeteeklee6_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "ROSE";
            urunusepet.image0.Source = image449.Source;
            urunusepet.image2.Source = image449.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"images/rose-bot-d0189007739-cdc3.", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "ROSE";
            urunusepet.labe2.Content = "Rose-bot-d0189007739-cdc3";
            urunusepet.labe3.Text = label6.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati6.Text;
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }
        private void sepeteeklee7_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "SİYAH";
            urunusepet.image0.Source = image450.Source;
            urunusepet.image2.Source = image450.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"images/black-kadin-bot-k0777042303-08d9.", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "BAMBİ";
            urunusepet.labe2.Content = "BLACK BAYAN BOT K0777042303";
            urunusepet.labe3.Text = label7.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati7.Text;
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }
        private void sepeteeklee8_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "SİYAH";
            urunusepet.image0.Source = image450.Source;
            urunusepet.image2.Source = image450.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"images/siyah-bot-k0528051003-6033.", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "BAMBİ";
            urunusepet.labe2.Content = "SIYAH KADIN BOT K0528051003";
            urunusepet.labe3.Text = label8.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati8.Text;
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }
        private void sepeteeklee9_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "BEYAZ";
            urunusepet.image0.Source = image451.Source;
            urunusepet.image2.Source = image451.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"images/beyaz-bot-k0536410009-b0fd.", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "BAMBİ";
            urunusepet.labe2.Content = "BEYAZ KADIN BOT K0536410009";
            urunusepet.labe3.Text = label9.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati9.Text;
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }
        private void sepeteeklee10_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "OLİVE";
            urunusepet.image0.Source = image452.Source;
            urunusepet.image2.Source = image452.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"images/olive-bayan-bot-k0777052503-a9c3.", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "BAMBİ";
            urunusepet.labe2.Content = "Olive-bayan-bot-k0777052503";
            urunusepet.labe3.Text = label10.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati10.Text;
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }
        private void sepeteeklee11_Click(object sender, RoutedEventArgs e)
        {
            urunusepeteekle urunusepet = new urunusepeteekle();
            urunusepet.butonrengi.Content = "SİYAH";
            urunusepet.image0.Source = image453.Source;
            urunusepet.image2.Source = image453.Source;
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(@"images/siyah-bot-k0512111009-0f55.", UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();
            urunusepet.image1.Source = bitmapImage;
            urunusepet.labe1.Content = "BAMBİ";
            urunusepet.labe2.Content = "SIYAH KADIN BOT K0512111009";
            urunusepet.labe3.Text = label11.Content.ToString();
            urunusepet.texblock.Text = sepetfiyati11.Text;
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                urunusepet.uyeyerigrid.Visibility = Visibility.Hidden;
                urunusepet.uyeyeri44.Visibility = Visibility.Visible;
                urunusepet.Show();
                this.Close();
            }
            else
            {
                urunusepet.Show();
                this.Close();
            }
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            uyeol uyeol = new uyeol();
            if (uyeyeri44.Visibility == Visibility.Visible && uyeyerigrid.Visibility == Visibility.Hidden)
            {
                uyeol.uyeyerigrid.Visibility = Visibility.Hidden;
                uyeol.uyeyeri44.Visibility = Visibility.Visible;
                uyeol.Show();
                this.Close();
            }
            else
            {
                uyeol.Show();
                this.Close();
            }
            this.Close();
        }

        private void stoktakiler_Click(object sender, RoutedEventArgs e)
        {
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
    }
}
