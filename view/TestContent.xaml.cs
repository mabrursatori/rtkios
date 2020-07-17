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

namespace rtkios.view
{
    /// <summary>
    /// Interaction logic for TestContent.xaml
    /// </summary>
    public partial class TestContent : UserControl
    {
        public TestContent()
        {
            InitializeComponent();
            string dateNow = DateTime.Now.ToShortDateString();
            string timeNow = DateTime.Now.ToShortTimeString();
            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Pin = 51, Name = "Mabrur Developer", Date = dateNow, Time = timeNow, Status = "Terlalu Pagi" });
            users.Add(new User() { Id = 2, Pin = 52, Name = "Mabrur Software Engineer", Date = dateNow, Time = timeNow, Status = "Terlalu Rajin" });
            users.Add(new User() { Id = 3, Pin = 53, Name = "Mabrur Data Scientist", Date = dateNow, Time = timeNow, Status = "Terlalu Profesional" });

            dgUsers.ItemsSource = users;
        }
    }

    public class User
    {
        public int Id { get; set; }
        public int Pin { get; set; }
        public string Name { get; set; }
        public string Birthday { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Status { get; set; }
    }
}
