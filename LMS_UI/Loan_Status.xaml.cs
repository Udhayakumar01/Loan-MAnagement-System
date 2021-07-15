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
    /// Interaction logic for Loan_Status.xaml
    /// </summary>
    public partial class Loan_Status : Window
    {
        int Id;
        public Loan_Status()
        {
            InitializeComponent();
            Id = Customer_Login.Id;

        }

        private void Button_Click_View(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_CustomerId.Text))
            {
                int CustomerID = int.Parse(txt_CustomerId.Text);
                if (CustomerID == Id)
                {
                    int CustomerId = int.Parse(txt_CustomerId.Text);
                    Bl_ApplyLoan bl_ApplyLoan = new Bl_ApplyLoan();
                    ApplyLoan applyLoan = bl_ApplyLoan.ViewLoanStatus(CustomerId);
                    ApplyLoan[] Array = new ApplyLoan[] { applyLoan };
                    dataGrid.ItemsSource = Array;
                }
                else
                {
                    MessageBox.Show("Please Enter Your Valid Customer ID To View Loan Status");
                }
            }
            else
            {
                MessageBox.Show("Please Enter Your Valid Customer ID To View Loan Status");
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
    }
}
