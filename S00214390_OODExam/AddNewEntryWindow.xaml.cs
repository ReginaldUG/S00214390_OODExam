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
using System.Windows.Shapes;

namespace S00214390_OODExam
{
    /// <summary>
    /// Interaction logic for AddNewEntryWindow.xaml
    /// </summary>
    public partial class AddNewEntryWindow : Window
    {
        public AddNewEntryWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //reference to the main window           
            MainWindow main = this.Owner as MainWindow;
            //Obeject to store value for selected character that is gotten from the "main" window
            
        }
    }
}
