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
using ClassLibrary1;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> Users = new List<User> { new User("Bill",36) };

        public MainWindow()
        {
            InitializeComponent();
            DataGrid.ItemsSource = Users;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Users.Add(new User(NameInput.Text, int.Parse(AgeInput.Text)));
            DataGrid.ItemsSource = null;
            DataGrid.ItemsSource = Users;
        }
    }
}
