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
using LMS_ENTITY;
using LMS_BL;
using System.Data.SqlClient;
using System.Data;
using System.Text.RegularExpressions;


namespace LMS_UI
{
    /// <summary>
    /// Interaction logic for Customer_Login.xaml
    /// </summary>
    public partial class Customer_Login : Window
    {
        public static int Id;

        public Customer_Login()
        {
            InitializeComponent();
        }

        private void Button_Click_Login(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_CustomerId.Text))
            {
                Id = int.Parse(txt_CustomerId.Text);
                int CustomerId = 0;
                string Password = null;
                if (txt_CustomerId.Text.Length > 0)
                {
                    CustomerId = Int32.Parse(txt_CustomerId.Text);
                }
                else
                {
                    MessageBox.Show("Enter Customer Id");
                }
                if (txt_Password.Password.Length > 0)
                {
                    Password = txt_Password.Password;
                }
                else
                {
                    MessageBox.Show("Please Enter Password");
                }
                Bl_Customer bl_Customer = new Bl_Customer();
                bool flag = bl_Customer.CustomerLogin(CustomerId, Password);
                if (flag)
                {
                    this.Hide();
                    MainWindow1 MW1 = new MainWindow1();
                    MW1.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Login Credentials");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Valid Login Credentials");

            }
        }

        private void Button_Click_Register(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Customer_Registration CR = new Customer_Registration();
            CR.Show();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow_Login MWL = new MainWindow_Login();
            MWL.Show();
        }

        private void txt_CustomerId_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
