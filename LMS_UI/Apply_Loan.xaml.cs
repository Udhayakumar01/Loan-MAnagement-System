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
    /// Interaction logic for Apply_Loan.xaml
    /// </summary>
    public partial class Apply_Loan : Window
    {
        int Id;
        public string[] LoanType { get; set; }
        public Apply_Loan()
        {
            InitializeComponent();
            LoanType = new string[] { "Home Loan", "Vehicle Loan", "Education Loan" };
            DataContext = this;
            Id = Customer_Login.Id;
        }

        private void Button_Click_Apply(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_CustomerId.Text))
            {
                int CustomerId = int.Parse(txt_CustomerId.Text);
                if (CustomerId == Id)
                {
                    ApplyLoan applyLoan = new ApplyLoan();
                    applyLoan.CUSTOMER_ID = int.Parse(txt_CustomerId.Text);
                    applyLoan.LOAN_AMOUNT = int.Parse(txt_LoanAmount.Text);
                    applyLoan.LOAN_TYPE = txt_LoanType.Text;
                    applyLoan.TENURE = int.Parse(txt_Tenure.Text);
                    Bl_ApplyLoan bl_ApplyLoan = new Bl_ApplyLoan(applyLoan);
                    bool flag = bl_ApplyLoan.ApplyLoanApplication();
                    if (flag)
                    {
                        System.Windows.Forms.MessageBox.Show("Loan Application Submitted Successfully");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Loan Application Not Submitted ");

                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Your Valid Customer ID To Apply For Loan");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Valid Customer ID To Apply For Loan");
            }
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow1 MW1 = new MainWindow1();
            MW1.Show();
        }

        private void txt_CustomerId_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txt_LoanAmount_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }

        private void txt_Tenure_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
