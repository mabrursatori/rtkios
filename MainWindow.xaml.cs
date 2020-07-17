using rtkios.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace rtkios
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool StateClosed = false;
        public MainWindow()
        {
            string dateNow = DateTime.Now.ToShortDateString();
            string timeNow = DateTime.Now.ToShortTimeString();
            InitializeComponent();
            //int WidthScress = Convert.ToInt32(System.Windows.SystemParameters.WorkArea.Width);
            //int HeigthScress = Convert.ToInt32(System.Windows.SystemParameters.WorkArea.Height);
            //MessageBox.Show(WidthScress.ToString() + " " + HeigthScress.ToString());
            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Pin = 51, Name = "Mabrur Satori", Date = dateNow, Time = timeNow, Status = "Terlalu Pagi" });
            users.Add(new User() { Id = 2, Pin = 52, Name = "Mabrur Software Engineer", Date = dateNow, Time = timeNow, Status = "Terlalu Rajin" });
            users.Add(new User() { Id = 3, Pin = 53, Name = "Mabrur Data Scientist", Date =dateNow, Time = timeNow, Status = "Terlalu Profesional" });
            //setDefaultPage();





            dgUsers.ItemsSource = users;

            
        }

        private void ButtonMenu_Click(object sender, RoutedEventArgs e)
        {
            
            if (StateClosed)
            {
                Storyboard sb = this.FindResource("CloseMenu") as Storyboard;
                sb.Begin();
                TestContent mabrur = new TestContent();
                mabrur.GridCard.Width = 10;

            }
            else
            {
                Storyboard sb = this.FindResource("OpenMenu") as Storyboard;
                sb.Begin();
            }

            StateClosed = !StateClosed;
        }

        //private void setDefaultPage()
        //{
        //    BackgroundWorker worker = new BackgroundWorker();


        //    worker.RunWorkerCompleted += (o, a) =>
        //    {

        //        frameConten.Content = new TestContent();

        //    };
        //    worker.RunWorkerAsync();
        //}

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        //private void Btn_Click(object sender, RoutedEventArgs e)
        //{
        //    Setting open = new Setting();
        //    open.Show();
        //}

        //private void btn_ExportData(object sender, RoutedEventArgs e)
        //{
        //    ExportData exportData = new ExportData();
        //    exportData.Show();
        //}

        //private void btn_LogOut(object sender, RoutedEventArgs e)
        //{
        //    System.Windows.Application.Current.Shutdown();
        //}
    }

    public class User
    { 
        public int Id { get; set; }

        public int Pin { get; set; }

        public string Name { get; set; }

        public string Birthday { get; set; }

        public string Date { get; set; }

        public string Time { get; set; }

        public string Status  { get; set; }
    }
  


}
