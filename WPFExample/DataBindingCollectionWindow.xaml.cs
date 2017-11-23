using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for DataBindingCollectionWindow.xaml
    /// </summary>
    public partial class DataBindingCollectionWindow : Window
    {
        private ObservableCollection<MyData> _myCollection =
      new ObservableCollection<MyData>();
 
        public DataBindingCollectionWindow()
        {
            InitializeComponent();
             DataContext = _myCollection;
      _myCollection.Add(
        new MyData
        {
          FirstName = "Arik",
          LastName = "Poznanski",
          IsLecturer = true
        });
      _myCollection.Add(
        new MyData
        {
          FirstName = "John",
          LastName = "Smith",
          IsLecturer = false
        });
    }
       
 
    private int counter = 0;
    
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            ++counter;
            _myCollection.Add(
                new MyData()
                {
                    FirstName = "item " + counter,
                    LastName = "item " + counter,
                    IsLecturer = counter % 3 == 0
                });
        }

    }
}

