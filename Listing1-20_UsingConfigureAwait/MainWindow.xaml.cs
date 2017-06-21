using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace Listing1_20_UsingConfigureAwait
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

        public object Output { get; private set; }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            HttpClient httpClient = new HttpClient();

            string content = await httpClient
                .GetStringAsync("http://www.microsoft.com")
                .ConfigureAwait(false);

            //Output.Content = content; //Throws an exception because of line 38
        }
    }
}
