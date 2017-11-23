using System;
using System.Collections.Generic;
using System.ComponentModel;
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
using System.Windows.Shapes;

namespace WPFExample
{
    /// <summary>
    /// Interaction logic for Databinding.xaml
    /// </summary>
    public partial class DatabindingWindow : Window
    {
        private MyData _myData;
       

        public DatabindingWindow()
        {
            InitializeComponent();

            _myData = new MyData()
            {
                User = "Yair",
                Password = "123456"
            };

            byMydata.DataContext =_myData;

           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_myData.User == "Yair")
            {
                _myData.User = "Moshe";
            }
            else
            {
                _myData.User = "Yair";
            }
        }

    }

   
}

