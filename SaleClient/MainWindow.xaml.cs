using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
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

namespace SaleClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string actionUrl;
        public List<ClientsClass.Sale> qwe = new List<ClientsClass.Sale>();

        public MainWindow()
        {
            InitializeComponent();
            
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("fds");
            try
            {

                DateTime datest = Convert.ToDateTime(TbStart.Text);
                DateTime dateend = Convert.ToDateTime(TbEnd.Text);
                actionUrl = $"https://localhost:7100/api/Sale?dateStart={datest}&dateEnd={dateend}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(Convert.ToString(ReturnData().Count));

            listD.ItemsSource = null;

            qwe = ReturnData();
            listD.ItemsSource = qwe;
        }


        public List<ClientsClass.Sale> ReturnData()
        {
var cli = new WebClient();
            cli.Headers[HttpRequestHeader.ContentType] = "application/json";
            //cli.Headers[CharSet.None] ="utf-8";
            string response = cli.UploadString(actionUrl, "{some:\"json data\"}");
            return JsonConvert.DeserializeObject<List<ClientsClass.Sale>>(response);
        }

    }
}
