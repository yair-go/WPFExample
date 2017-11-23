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

namespace WPFExample
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

        private void DataBindigButton_Click(object sender, RoutedEventArgs e)
        {
            DatabindingWindow databindingWindow = new DatabindingWindow();
            databindingWindow.ShowDialog();

        }

        private void DataBindigButton2_Click(object sender, RoutedEventArgs e)
        {
            DatabindingWindow2 databindingWindow = new DatabindingWindow2();
            databindingWindow.Show();
        }

        private void DataBindigButton1_Click(object sender, RoutedEventArgs e)
        {
            DataBindingCollectionWindow dbcw = new DataBindingCollectionWindow();
            dbcw.Show();
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            App.Current.Shutdown();
        }

       
        private void tb1_IsMouseDirectlyOverChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            tb1.FontSize = tb1.FontSize * 2;
        }

        private void tb_MouseMove(object sender, MouseEventArgs e)
        {
            ((TextBox)sender).FontSize+=2;
           // tb1.FontSize = tb1.FontSize * 2;
        }

        private void DataBindigButton_MouseMove(object sender, MouseEventArgs e)
        {
            ((Button)sender).FontSize*=2;
        }

        private void DataBindigButton_MouseLeave(object sender, MouseEventArgs e)
        {
            ((Button)sender).FontSize/=2;
        }

       

       
    }
}
