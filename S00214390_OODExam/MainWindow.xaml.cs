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

namespace S00214390_OODExam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<RentalProperty> MyRentList = new List<RentalProperty>();

        public MainWindow()
        {
            InitializeComponent();
        }
        RentalData db = new RentalData();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query = from r in db.Rental
                        orderby r.Price ascending
                        select r;

            LstBox_DisplayRent.ItemsSource = query.ToList();

        }

        private void LstBox_DisplayRent_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            RentalProperty selectedRentItem = new RentalProperty();
            if (LstBox_DisplayRent.SelectedItem != null)
            {
                selectedRentItem = (RentalProperty)LstBox_DisplayRent.SelectedItem;
                txtBlck_DisplayDesc.Text = selectedRentItem.Description;
            }
        }
    }
}
