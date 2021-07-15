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
using System.Text.RegularExpressions;
using LMS_BL;
using LMS_ENTITY;
using LMS_EXCEPTION;

namespace LMS_UI
{
    /// <summary>
    /// Interaction logic for View_Customer_Details.xaml
    /// </summary>
    public partial class View_Customer_Details : Window
    {
        int Id;
        public View_Customer_Details()
        {
            InitializeComponent();
            Id = Customer_Login.Id;

        }

        private void Button_Click_View(object sender, RoutedEventArgs e)
        {
            if( !String.IsNullOrEmpty(txt_CustomerId.Text))
            { 
                int CustomerId = int.Parse(txt_CustomerId.Text);
                if (CustomerId == Id)
                {
                    Bl_ApplyLoan bl_ApplyLoan = new Bl_ApplyLoan();
                    Customer customer = bl_ApplyLoan.ViewCustomerDetails(CustomerId);
                    Customer[] CustomerArray = new Customer[] { customer };
                    DataGrid.ItemsSource = CustomerArray;
                }
                else
                {
                    MessageBox.Show("Enter your valid Customer ID");
                }
            }
            else
            {
                MessageBox.Show("Customer ID Cannot be Null or Empty");

            }
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Personal_Information PW = new Personal_Information();
            PW.Show();
        }

        private void txt_CustomerId_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
