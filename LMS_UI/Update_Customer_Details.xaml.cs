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
    /// Interaction logic for Update_Customer_Details.xaml
    /// </summary>
    public partial class Update_Customer_Details : Window
    {
        int Id;
        public Update_Customer_Details()
        {
            InitializeComponent();
            Id = Customer_Login.Id;
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_CustomerId.Text))
            {
                int CustomerId = Int32.Parse(txt_CustomerId.Text);
                if (CustomerId == Id)
                {
                    Customer customer = new Customer();
                    customer.CUSTOMER_ID = Int32.Parse(txt_CustomerId.Text);
                    customer.FIRST_NAME = txt_FirstName.Text;
                    customer.LAST_NAME = txt_LastName.Text;
                    customer.ADDRESS = txt_Address.Text;
                    customer.PAN_NUMBER = txt_PanNumber.Text;
                    customer.AADHAR_NUMBER = (long)(Convert.ToInt64(txt_AadharNumber.Text));
                    customer.CONTACT_NUMBER = (long)(Convert.ToInt64(txt_ContactNumber.Text));
                    customer.DOB = DateTime.Parse(txt_Dob.Text);
                    customer.CREDIT_LIMIT = Int32.Parse(txt_CreditLimit.Text);
                    customer.LAST_UPDATED_CREDIT_DATE = DateTime.Parse(txt_LastCreditUpdateDate.Text);

                    Bl_ApplyLoan bl = new Bl_ApplyLoan(customer);
                    bool flag = bl.UpdateCustomer(customer.CUSTOMER_ID);
                    if (flag)
                    {
                        MessageBox.Show("Customer Details Updated Successfully..!");
                    }
                    else
                    {
                        MessageBox.Show("Customer Details Not Updated..!");
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Your Valid ID");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Customer ID");
            }
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Personal_Information PF = new Personal_Information();
            PF.Show();
        }

        private void txt_CustomerId_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        #region Validation
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

        private void txt_AadharNumber_PreviewText(object sender, TextCompositionEventArgs e)
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

        private void txt_CreditLimit_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        #endregion
    }
}
