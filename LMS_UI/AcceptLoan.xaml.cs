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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Text.RegularExpressions;
using LMS_BL;
using LMS_ENTITY;
using LMS_EXCEPTION;
using System.Data.SqlClient;
using System.Data;

namespace LMS_UI
{
    /// <summary>
    /// Interaction logic for AcceptLoan.xaml
    /// </summary>
    public partial class AcceptLoan : Window
    {
        public AcceptLoan()
        {
            InitializeComponent();
            Bl_ManageLoan lms_Bl = new Bl_ManageLoan();
            List<ApplyLoan> list = lms_Bl.ShowAllEligibleCustomers().ToList();
            dataGrid.ItemsSource = list;
        }

        private void btn_Return_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow mw = new MainWindow();
            mw.Show();
        }

        private void btn_Accept_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_CustomerId.Text))
            {
                try
                {
                    int flag = 0;
                    Bl_ManageLoan lms_Bl = new Bl_ManageLoan();
                    int CustomerId = int.Parse(txt_CustomerId.Text);
                    flag = lms_Bl.AddLoanDetails(CustomerId);
                    if (flag > 0)
                    {
                        lms_Bl.UpdateStatusTypeApproved(CustomerId);
                        lms_Bl.InsertManageLoan(CustomerId);
                        MessageBox.Show("Loan Application Accepted");
                        lms_Bl.DeleteFromApplyLoan(CustomerId);
                    }
                    else
                    {
                        MessageBox.Show("Loan Application Not Accepted");
                        //lms_Bl.UpdateStatusTypeRejected(CustomerId);
                        //lms_Bl.DeleteFromApplyLoan(CustomerId);
                    }
                }
                catch (Exception EX)
                {
                    System.Windows.Forms.MessageBox.Show(EX.Message);
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Enter Customer ID..!");

            }
        }

        private void txt_CustomerId_PreviewText(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
        
    }
}
