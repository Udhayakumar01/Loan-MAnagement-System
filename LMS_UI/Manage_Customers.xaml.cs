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
    /// Interaction logic for Manage_Customers.xaml
    /// </summary>
    public partial class Manage_Customers : Window
    {
        public Manage_Customers()
        {
            InitializeComponent();
        }

        private void deleteEmployee_Click(object sender, RoutedEventArgs e)
        {
            int CustomerId = 0;
            int flag;
            if (!string.IsNullOrEmpty(txt_CustomerId.Text))
            {
                if (int.Parse(txt_CustomerId.Text) > 0)
                {
                    CustomerId = int.Parse(txt_CustomerId.Text);
                }
                else
                {
                    MessageBox.Show("Enter Customer ID");
                }
                Bl_Customer bl_Customer = new Bl_Customer();
                flag = bl_Customer.DeleteCustomer(CustomerId);
                if (flag > 0)
                {
                    MessageBox.Show("Customer Record Deleted Successfully");
                }
                else
                {
                    MessageBox.Show("Customer Record Not Deleted ");

                }
            }
            else
            {
                MessageBox.Show("Enter Valid Customer ID to Delete ");

            }

        }

        private void updateEmployee_Click(object sender, RoutedEventArgs e)
        {
            int CustomerId = 0;
            int flag;
            if (!string.IsNullOrEmpty(txt_CustomerId.Text))
            {
                if (int.Parse(txt_CustomerId.Text) > 0)
                {
                    CustomerId = int.Parse(txt_CustomerId.Text);
                }
                else
                {
                    MessageBox.Show("Enter Customer ID");
                }
                Customer customer = new Customer();
                if (txt_FirstName.Text.Length > 0)
                {
                    customer.FIRST_NAME = txt_FirstName.Text;
                }
                else
                {
                    MessageBox.Show("First Name Cannot Be Empty. Please Enter a Valid Name");
                }
                if (txt_LastName.Text.Length > 0)
                {
                    customer.LAST_NAME = txt_LastName.Text;
                }
                else
                {
                    MessageBox.Show("Last Name Cannot Be Empty. Please Enter a Valid Name");

                }
                if (txt_Address.Text.Length > 0)
                {
                    customer.ADDRESS = txt_Address.Text;
                }
                else
                {
                    MessageBox.Show("Address Cannot Be Empty. Please Enter a Valid Address");
                }
                if ((txt_PanNumber.Text.Length > 0) && (txt_PanNumber.Text.Length <= 10))
                {
                    customer.PAN_NUMBER = txt_PanNumber.Text;
                }
                else
                {
                    MessageBox.Show("Please Enter a Pan Number");

                }
                if ((txt_AadharNumber.Text.Length > 0) && (txt_AadharNumber.Text.Length == 12))
                {
                    customer.AADHAR_NUMBER = (long)Convert.ToInt64(txt_AadharNumber.Text);
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Aadhar Number");

                }
                if ((txt_ContactNumber.Text.Length > 0) && (txt_ContactNumber.Text.Length == 10))
                {
                    customer.CONTACT_NUMBER = (long)Convert.ToInt64(txt_ContactNumber.Text);
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Contact Number");

                }
                if (txt_Email.Text.Length > 0)
                {
                    customer.EMAIL = txt_Email.Text;
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Email ID");

                }
                customer.DOB = DateTime.Parse(txt_Dob.Text);
                if (txt_CreditLimit.Text.Length > 0)
                {
                    customer.CREDIT_LIMIT = int.Parse(txt_CreditLimit.Text);
                }
                else
                {
                    MessageBox.Show("Please Enter a Valid Credit Amount");
                }
                customer.LAST_UPDATED_CREDIT_DATE = DateTime.Parse(txt_LastUpdatedCreditDate.Text);
                Bl_Customer bl_Customer = new Bl_Customer(customer);
                flag = bl_Customer.UpdateCustomer(CustomerId);
                if (flag > 0)
                {
                    MessageBox.Show("Customer Details Updated Successfully");
                }
                else
                {
                    MessageBox.Show("Customer Details Not Updated ");

                }
            }
            else
            {
                MessageBox.Show("Enter Valid Customer ID To Update ");
            }


        }

        #region Validation
        private void Back_Click_Back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Employee_Operations EO = new Employee_Operations();
            EO.Show();
        }

        private void txt_FirstName_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txt_LastName_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txt_AadharNumber_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txt_PanNumber_PreviewText(object sender, TextCompositionEventArgs e)
        {
            string pattern = @"^[A-Z]{5}[0-9]{4}[A-Z]{0,1}$";
            if (Regex.IsMatch(txt_PanNumber.Text, pattern) == false)
            {
                string a = "Pan Number Format Eg. ABCDE1234F";
                lbl_PanNumber_PreviewText.Content = a;
                return;
            }
            lbl_PanNumber_PreviewText.Content = "";
        }

        private void txt_ContactNumber_PreviewText(object sender, TextCompositionEventArgs e)
        {
            string pattern = @"^[6789]{0,1}[0-9]{0,8}$";
            if (Regex.IsMatch(txt_ContactNumber.Text, pattern) == false)
            {
                MessageBox.Show("ENTER A VALID CONTACT NUMBER  i.e IT SHOULD NOT EXCEED 10 DIGITS AND IT SHOULD START WITH EITHER 6,7,8 OR 9");
            }
        }

        private void txt_Email_PreviewText(object sender, TextCompositionEventArgs e)
        {
            string pattern = (@"^([a-z\d\.-_]+)@([a-z\d-])+\.([a-z]{2,8})$");

            if (Regex.IsMatch(txt_Email.Text, pattern) == false)
            {
                string a = "Email Fromat. \nEg. abc12@gmail.com";
                lbl_Email_PreviewText.Content = a;
                return;
            }
            lbl_Email_PreviewText.Content = "";
        }

        private void txt_CreditLimit_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txt_CustomerId_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        #endregion
    }
}
