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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace OkulOtomasyonu.Windows
{
    /// <summary>
    /// Interaction logic for AnaEkran.xaml
    /// </summary>
    public partial class AnaEkran : Window
    {
        public AnaEkran()
        {
            InitializeComponent();
            menuKapaliMi = true;
        }

        public bool menuKapaliMi { get; set; }

        private void Rectangle_PreviewDragOver(object sender, DragEventArgs e)
        {

        }

        private void Rectangle_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            DragMove(); //ekranı tutup hareket ettşrmek için buyuk dikdortgen
        }

        private void menuButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuButton_Checked(object sender, RoutedEventArgs e)
        {
            if (!menuKapaliMi)
            {
                Storyboard storyboard = this.FindResource("menuAc") as Storyboard;
                storyboard.Begin();
            }
            else if (menuKapaliMi)
            {
                Storyboard storyboard = this.FindResource("menuKapat") as Storyboard;
                storyboard.Begin();

            }
            menuKapaliMi = !menuKapaliMi; //menukapalımı: false ise true cevirir
        }
    }
}
