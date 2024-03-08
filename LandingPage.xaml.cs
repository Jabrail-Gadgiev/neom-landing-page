using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
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

namespace EnrollmentDesktopApp.Pages
{
    /// <summary>
    /// Interaction logic for LandingPage.xaml
    /// </summary>
    public partial class LandingPage : Page
    {

        public LandingPage()
        {
            InitializeComponent();
            //loggedin.Text = "User : " + Application.Current.Properties["UserName"] as string;
            //DeviceID.Text = Dns.GetHostName();

            var converter = new BrushConverter();
            ObservableCollection<Member> members = new ObservableCollection<Member>();

            members.Add(new Member { tid = "123456", GivenName = "Reza Alavi", time = "10:00 AM", Status = "Completed", DigtialID = "254-451-7893" });
            members.Add(new Member { tid = "123456", GivenName = "Reza Alavi", time = "10:00 AM", Status = "Completed", DigtialID = "254-451-7893" });
            members.Add(new Member { tid = "123456", GivenName = "Reza Alavi", time = "10:00 AM", Status = "Completed", DigtialID = "254-451-7893" });
            members.Add(new Member { tid = "123456", GivenName = "Reza Alavi", time = "10:00 AM", Status = "Completed", DigtialID = "254-451-7893" });

            membersDataGrid.ItemsSource = members;

        }
        public class Member
        {
            public string tid { get; set; }
            public string DigtialID { get; set; }
            public string GivenName { get; set; }
            public string time { get; set; }
            public string Status { get; set; }

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Start_Enrollment(object sender, RoutedEventArgs e)
        {
            NavigateToDashboard();
        }

        private void NavigateToDashboard()
        {
            Uri dashboardUri = new Uri("/EnrollmentDesktopApp;component/Pages/EnrollmentStartPage.xaml", UriKind.Relative);
            NavigationService.Navigate(dashboardUri);
        }
    }
}
