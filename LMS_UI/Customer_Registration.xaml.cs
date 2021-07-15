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
using LMS_ENTITY;
using LMS_BL;
using LMS_EXCEPTION;

namespace LMS_UI
{
    /// <summary>
    /// Interaction logic for Customer_Registration.xaml
    /// </summary>
    public partial class Customer_Registration : Window
    {
        public Customer_Registration()
        {
            InitializeComponent();
        }

        private void Register_Employee_Click(object sender, RoutedEventArgs e)
        {
            int flag;
            Customer customer = new Customer();
            if (txt_FirstName.Text.Length > 0)
            {
                customer.FIRST_NAME = txt_FirstName.Text;
            }
            else
            {
                MessageBox.Show("First Name Cannot Be Empty. Please Enter a Valid Name");
                return;
            }
            if (txt_LastName.Text.Length > 0)
            {
                customer.LAST_NAME = txt_LastName.Text;
            }
            else
            {
                MessageBox.Show("Last Name Cannot Be Empty. Please Enter a Valid Name");
                return;

            }
            if (txt_Address.Text.Length > 0)
            {
                customer.ADDRESS = txt_Address.Text;
            }
            else
            {
                MessageBox.Show("Address Cannot Be Empty. Please Enter a Valid Address");
                return;
            }
            if ((txt_PanNumber.Text.Length > 0)  && (txt_PanNumber.Text.Length <=10))
            {
                customer.PAN_NUMBER = txt_PanNumber.Text;
            }
            else
            {
                MessageBox.Show("Please Enter a Pan Number");
                return;

            }
            if ((txt_AadharNumber.Text.Length > 0) && (txt_AadharNumber.Text.Length == 12))
            {
                customer.AADHAR_NUMBER = (long)Convert.ToInt64(txt_AadharNumber.Text);
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Aadhar Number");
                return;

            }
            if((txt_ContactNumber.Text.Length > 0) && (txt_ContactNumber.Text.Length == 10))
            {
                customer.CONTACT_NUMBER = (long)Convert.ToInt64(txt_ContactNumber.Text);
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Contact Number");
                return;

            }
            if (txt_Email.Text.Length > 0)
            {
                customer.EMAIL = txt_Email.Text;
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Email ID");
                return;

            }
            if (!string.IsNullOrEmpty(txt_Dob.Text))
            {
                customer.DOB = DateTime.Parse(txt_Dob.Text);
            }
            else
            {
                MessageBox.Show("Please Enter DOB");
                return;
            }
            if (txt_CreditLimit.Text.Length > 0)
            {
                customer.CREDIT_LIMIT = int.Parse(txt_CreditLimit.Text);
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Credit Amount");
                return;
            }
            if (!string.IsNullOrEmpty(txt_LastUpdatedCreditDate.Text))
            {
                customer.LAST_UPDATED_CREDIT_DATE = DateTime.Parse(txt_LastUpdatedCreditDate.Text);
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Last Updated Credit Date");
                return;

            }
            if (txt_Password.Password.Length > 0)
            {
                customer.Password = txt_Password.Password;
            }
            else
            {
                MessageBox.Show("Please Enter a Valid Password");
                return;

            }
            Bl_Customer bl_Customer = new Bl_Customer(customer);
            flag = bl_Customer.AddCustomer();
            if(flag > 0)
            {
                MessageBox.Show("Customer Record Added Successfully");
                MessageBox.Show($"Your Customer ID Is {bl_Customer.GetCustomerIdAfterRegistration()}");

            }
            else
            {
                MessageBox.Show("Customer Record Not Added");

            }

        }

        private void Back_Click_Back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Customer_Login CL = new Customer_Login();
            CL.Show();
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
                string a = "Pan Number Format. \nEg. ABCDE1234F";
                lbl_PanNumber_PreviewText.Content = a;
                return;
            }
            lbl_PanNumber_PreviewText.Content = "";
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

        private void txt_ContactNumber_PreviewText(object sender, TextCompositionEventArgs e)
        {
            string pattern = @"^[6789]{0,1}[0-9]{0,8}$";
            if (Regex.IsMatch(txt_ContactNumber.Text, pattern) == false)
            {
                MessageBox.Show("ENTER A VALID CONTACT NUMBER  i.e IT SHOULD NOT EXCEED 10 DIGITS AND IT SHOULD START WITH EITHER 6,7,8 OR 9");
            }
        }
    }
}
