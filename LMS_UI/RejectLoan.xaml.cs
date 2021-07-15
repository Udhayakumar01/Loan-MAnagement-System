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

namespace LMS_UI
{
    /// <summary>
    /// Interaction logic for RejectLoan.xaml
    /// </summary>
    public partial class RejectLoan : Window
    {
        public RejectLoan()
        {
            InitializeComponent();
            Bl_ManageLoan lms_Bl = new Bl_ManageLoan();
            List<ApplyLoan> list = lms_Bl.ShowAllNonEligibleCustomers().ToList();
            dataGrid.ItemsSource = list;
        }

        private void btn_Return_Click(object sender, RoutedEventArgs e)
        {
           this.Hide();
           MainWindow mw = new MainWindow();
            mw.Show();


        }

        private void btn_Reject_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_CustomerId.Text))
            {
                try
                {
                    int flag = 0;
                    int CustomerId = int.Parse(txt_CustomerId.Text);
                    Bl_ManageLoan lms_Bl = new Bl_ManageLoan();
                    lms_Bl.UpdateStatusTypeRejected(CustomerId);
                    lms_Bl.InsertManageLoan(CustomerId);
                    flag = lms_Bl.DeleteFromApplyLoan(CustomerId);
                    if (flag > 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Loan Application Rejected");

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
