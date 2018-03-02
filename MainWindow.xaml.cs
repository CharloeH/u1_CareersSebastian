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

        private void btnInfo1_Click(object sender, RoutedEventArgs e)
        {
            lblMainTitle.Content = "University of Waterloo: Computer Engineering";
            lblSecondaryTitle.Content = "WSO";
            BitmapImage bi = new BitmapImage(new Uri("http://badmintonclub.uwaterloo.ca/UniversityOfWaterloo_logo_vert_rgb.jpg"));
            imgCenter.Source = bi;
            MessageBoxResult mbr = MessageBox.Show("To view the number of students attending this universtity and the cost press yes. \n To view information about the campus and residence press no. \n to return to the home page press cancel. \n To view this box agian press info #1.", "caption", MessageBoxButton.YesNoCancel);
            {
                if (mbr == MessageBoxResult.Yes)
                {
                    lblMainTitle.Content = "Enrolment";
                    lblInfoCenter.Content = "In 2015 there were 36,670 students attending this University. \n The cost for one year of computer engineering is 1700$ with an \n additional cost of books being $2000";
                    lblSecondaryTitle.Content = "";
                    imgCenter.Visibility = Visibility.Hidden;
                }
                else if (mbr == MessageBoxResult.No)
                {
                    lblMainTitle.Content = "Campus and Residence Information";
                    lblSecondaryTitle.Content = " ";
                    lblInfoCenter.Content = "The University of Waterloo main campus is spread over 400 hectars of former farmland. \n The main residence for first year students is the village one. it has 1381 residents.";
                    imgCenter.Visibility = Visibility.Hidden;
                }
                else if (mbr == MessageBoxResult.Cancel)
                {
                    BitmapImage bi2 = new BitmapImage(new Uri("http://hhs.tldsb.on.ca/wp-content/uploads/sites/8/2014/09/HHS-logo.jpeg"));
                    lblMainTitle.Content = "Sebastian's Careers Project";
                    lblSecondaryTitle.Content = "Outlineing a university computer science course";
                    imgCenter.Source = bi2;
                }
            }

        }

      

        private void btnInfo2_Click(object sender, RoutedEventArgs e)
        {
            lblMainTitle.Content = "University of Waterloo: Computer Engineering";
            lblSecondaryTitle.Content = "WSO";
            BitmapImage bi = new BitmapImage(new Uri("http://badmintonclub.uwaterloo.ca/UniversityOfWaterloo_logo_vert_rgb.jpg"));
            imgCenter.Source = bi;
            MessageBoxResult mbr = MessageBox.Show("To view the recommended and required courses (prerequisites) along with their recommended marks press ok.\n to return to the home page press cancel.\n To view this box agian press info #2", "caption", MessageBoxButton.OKCancel);
            {if (mbr == MessageBoxResult.OK)
                {
                    lblMainTitle.Content = "Prerequisites";
                    lblSecondaryTitle.Content = "";
                    lblInfoCenter.Content = "The required courses to apply for Computer Engineering are: physics(70%),\n Advanced Functions (70%), Calculus and Vectors (70%), Chemistry (70%), English (70%)\n It is also recommended that you have a credit in Introduction to Computer Science and \n Computer science";
                    imgCenter.Visibility = Visibility.Hidden;
                }
                else if (mbr == MessageBoxResult.Cancel)
                {
                    BitmapImage bi2 = new BitmapImage(new Uri("http://hhs.tldsb.on.ca/wp-content/uploads/sites/8/2014/09/HHS-logo.jpeg"));
                    lblMainTitle.Content = "Sebastian's Careers Project";
                    lblSecondaryTitle.Content = "Outlineing a university computer science course";
                    imgCenter.Source = bi2;
                }
            }
        }

        private void btnInfo3_Click(object sender, RoutedEventArgs e)
        {
            lblMainTitle.Content = "University of Waterloo: Computer Engineering";
            lblSecondaryTitle.Content = "WSO";
            BitmapImage bi = new BitmapImage(new Uri("http://badmintonclub.uwaterloo.ca/UniversityOfWaterloo_logo_vert_rgb.jpg"));
            imgCenter.Source = bi;
            MessageBoxResult mbr = MessageBox.Show("To view the year one courses for this program press yes. \n To view the total number of courses and the number of years required to complete this course press no. \n To return to the home page press cancel. To view this box agian press info #3.", "caption", MessageBoxButton.OKCancel);
            {
                if (mbr == MessageBoxResult.OK)
                {
                    lblMainTitle.Content = "Year One Courses";
                    lblSecondaryTitle.Content = "";
                    lblInfoCenter.Content = "";
                    imgCenter.Visibility = Visibility.Hidden;
                }
                else if (mbr == MessageBoxResult.Cancel)
                {
                    BitmapImage bi2 = new BitmapImage(new Uri("http://hhs.tldsb.on.ca/wp-content/uploads/sites/8/2014/09/HHS-logo.jpeg"));
                    lblMainTitle.Content = "Sebastian's Careers Project";
                    lblSecondaryTitle.Content = "Outlineing a university computer science course";
                    imgCenter.Source = bi2;
                }
            }
        }
    }
}
