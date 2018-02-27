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

namespace u1CareersSebastian
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

        private void btnUniName_Click(object sender, RoutedEventArgs e)
        {
            lblMainTitle.Content = "University of Waterloo";
            lblSecondaryTitle.Content = "ICS3U";
            BitmapImage bi = new BitmapImage(new Uri("http://badmintonclub.uwaterloo.ca/UniversityOfWaterloo_logo_vert_rgb.jpg"));
            imgCenter.Source = bi;
            btnUniName.Visibility = Visibility.Hidden;
            btnDefault.Visibility = Visibility.Visible;
            MessageBoxResult mbr = MessageBox.Show("<info>", "caption", MessageBoxButton.YesNo);
            {
                if (mbr == MessageBoxResult.Yes)
                {
                    lblMainTitle.Content = "k";

                }
                else if (mbr == MessageBoxResult.No)
                {
                    lblMainTitle.Content = "lul no";
                }
            }

        }
    
        private void btnDefault_Click(object sender, RoutedEventArgs e)
        {
            lblMainTitle.Content = "Sebastian's Careers Project";
            lblSecondaryTitle.Content = "Outlining a university computer science course";
            BitmapImage bi = new BitmapImage(new Uri("http://hhs.tldsb.on.ca/wp-content/uploads/sites/8/2014/09/HHS-logo.jpeg"));
            imgCenter.Source = bi;
            btnUniName.Visibility = Visibility.Visible;
            btnDefault.Visibility = Visibility.Hidden;

        }
    }
}
