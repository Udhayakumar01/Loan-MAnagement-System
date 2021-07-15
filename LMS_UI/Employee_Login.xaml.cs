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
using System.Data.SqlClient;
using System.Data;

namespace LMS_UI
{
    /// <summary>
    /// Interaction logic for Employee_Login.xaml
    /// </summary>
    public partial class Employee_Login : Window
    {
        public Employee_Login()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            int EmpId;
            string Password;
            if (txt_EmployeeId.Text.Length > 0)
            {
                EmpId = Int32.Parse(txt_EmployeeId.Text);
            }
            else
            {
                MessageBox.Show("Enter Employee Id");
                return;
            }
            if (txt_Password.Password.Length > 0)
            {
                Password = txt_Password.Password;
            SqlConnection con = new SqlConnection();
            SqlDataReader myReader = null;
            con.ConnectionString = @"Server = DESKTOP-MBKK1D2\CAPG; Integrated Security = true; Database = LMS_DB";
            con.Open();
            SqlParameter P1 = new SqlParameter("@EmpId", EmpId);
            SqlCommand myCommand = new SqlCommand("select Password from BANK_EMPLOYEE where EmpId = @EmpId");
            myCommand.CommandType = CommandType.Text;
            myCommand.Parameters.Add(P1);
            myCommand.Connection = con;
            myReader = myCommand.ExecuteReader();
                if (myReader.Read())
                {
                    string password1 = myReader[0].ToString();
                    con.Close();


                    if (password1 == Password)
                    {
                        this.Hide();
                        Employee_Operations EO = new Employee_Operations();
                        EO.Show();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Valid Login Credentials");
                    }
                }


            }
            else
            {
                MessageBox.Show("Please Enter Password");
            }


        }

        private void btn_Register_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Employee_Registration ER = new Employee_Registration();
            ER.Show();
        }

        private void Back_Click_Back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow_Login MWL = new MainWindow_Login();
            MWL.Show();
        }

        private void txt_EmployeeId_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
