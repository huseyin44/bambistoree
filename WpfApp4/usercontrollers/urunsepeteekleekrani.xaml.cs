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
using WpfApp4.kullanıcıkosullari;

namespace WpfApp4.usercontrollers
{
    /// <summary>
    /// Interaction logic for urunsepeteekleekrani.xaml
    /// </summary>
    public partial class urunsepeteekleekrani : Window
    {
        public urunsepeteekleekrani()
        {
            InitializeComponent();
           
        }

        private void alisverisedevamet_Click(object sender, RoutedEventArgs e)
        {           
            this.Close();
        }

        private void sepetemizle_Click(object sender, RoutedEventArgs e)
        {
            grid1.Children.Clear();
            grid2.Visibility = Visibility.Visible;
        }

        private void guncelle_Click(object sender, RoutedEventArgs e)
        {
            
            double x = Convert.ToDouble(combobox2.SelectedIndex);
            double a = Convert.ToDouble(fiyat2.Content) * x;
            double b = Convert.ToDouble(kirmizifiyat.Content) * x;
            double c = b - a;
            borderfiyat5.Content = c.ToString();
            borderfiyat4.Content = a.ToString();
            borderfiyat6.Content = b.ToString();
            indirimfiyati.Content = (c * -1).ToString();
        }
    }
}
