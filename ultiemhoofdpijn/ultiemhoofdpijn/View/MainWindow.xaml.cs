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
using ultiemhoofdpijn.View;

namespace ultiemhoofdpijn
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string Username;
        private string Pass;
        public string username
        {
            get { return Username; }
            set { Username = value; }
        }
        public string pass
        {
            get { return Pass; }
            set { Pass = value; }
        }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Window_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            //makes the window dragable
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Closes the current page and opens Window1
            Window1 win = new Window1();
            win.Show();
           // this.Close(); 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Closes the current page
            this.Close();
        }
    }
}
