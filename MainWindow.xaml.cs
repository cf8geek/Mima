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

namespace Demo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private CollectionViewSource itemCollectionViewSource;
        public CollectionViewSource ItemCollectionViewSource
        {
            get 
            {
                return itemCollectionViewSource; 
            }
            set 
            { 
                itemCollectionViewSource = value; 
            }
        }


        public MainWindow()
        {
            InitializeComponent();
            PopulateGrid();
        }

        private void PopulateGrid()
        {
            var arrSomeInfo = new List<TileInfo>() 
            {
            new TileInfo(){ ID="3", Title="test", ViewCount="55"},
            new TileInfo(){ ID="3", Title="test", ViewCount="55"},
            new TileInfo(){ ID="3", Title="test", ViewCount="55"},
            new TileInfo(){ ID="3", Title="test", ViewCount="55"},
            };

            var itemCollectionViewSource = (CollectionViewSource)(FindResource("ItemCollectionViewSource"));
            itemCollectionViewSource.Source = arrSomeInfo;

            this.MyGrid.ItemsSource = arrSomeInfo; 
        }

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            var data = new TileInfo
            {
                ID = IDTextbox.Text.Equals(string.Empty) ? "Filler" : IDTextbox.Text,
                Title = TitleTextbox.Text.Equals(string.Empty) ? "Filler" : TitleTextbox.Text,
                ViewCount = ViewCountTextbox.Equals(string.Empty) ? "Filler" : ViewCountTextbox.Text
            };

            MyGrid.Items.Add(data);
        }

    }

      
}
