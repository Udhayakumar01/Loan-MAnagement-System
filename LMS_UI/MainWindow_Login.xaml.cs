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

namespace LMS_UI
{
    /// <summary>
    /// Interaction logic for MainWindow_Login.xaml
    /// </summary>
    public partial class MainWindow_Login : Window
    {
        public MainWindow_Login()
        {
            InitializeComponent();
        }

        private void Button_Click_CustomerLogin(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Customer_Login CL = new Customer_Login();
            CL.Show();

        }

        private void Button_Click_EmployeeLogin(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Employee_Login EL = new Employee_Login();
            EL.Show();
        }
    }
}
