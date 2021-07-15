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
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using LMS_ENTITY;
using LMS_BL;

namespace LMS_UI
{
    /// <summary>
    /// Interaction logic for Employee_Registration.xaml
    /// </summary>
    public partial class Employee_Registration : Window
    {
        public string[] EmployeeType { get; set; }

        public Employee_Registration()
        {
            InitializeComponent();
            EmployeeType = new string[] { "Full Time","Part Time" };
            DataContext = this;

        }

        private void Button_Click_Register(object sender, RoutedEventArgs e)
        {
            try
            {
                BankEmployee bankEmployee = new BankEmployee();
                bankEmployee.EmpName = txt_EmployeeName.Text;
                bankEmployee.CONTACT_NUMBER = (long)Convert.ToInt64(txt_ContactNumber.Text);
                bankEmployee.EMAIL = txt_Email.Text;
                bankEmployee.EMP_TYPE = txt_EmployeeType.Text;
                bankEmployee.Password = txt_Password.Password;
                Bl_Employee bl_Employee = new Bl_Employee(bankEmployee);
                bool flag = bl_Employee.AddEmployee();
                if (flag)
                {
                    MessageBox.Show("Employee Record Added Successfully");
                    MessageBox.Show($"Your Employee ID Is {bl_Employee.GetEmployeeIdAfterRegistration()}");
                }
                else
                {
                    MessageBox.Show("Record Not Added..!");
                }
            }
            catch(SqlException SE)
            {
                MessageBox.Show(SE.Message);
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

        }

        private void Back_Click_Back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Employee_Login EL = new Employee_Login();
            EL.Show();
        }

        private void txt_EmployeeName_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
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

        private void txt_EmployeeType_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^a-zA-Z]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
