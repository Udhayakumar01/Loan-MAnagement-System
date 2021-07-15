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
    /// Interaction logic for Employee_Operations.xaml
    /// </summary>
    public partial class Employee_Operations : Window
    {
        public Employee_Operations()
        {
            InitializeComponent();
        }

        private void Button_Click_ManageCustomers(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Manage_Customers MC = new Manage_Customers();
            MC.Show();
        }

        private void Button_Click_ManageLoanApplications(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow MW = new MainWindow();
            MW.Show();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Employee_Login EL = new Employee_Login();
            EL.Show();
        }
    }
}
