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
using System.Windows.Navigation;
using LMS_BL;
using LMS_ENTITY;

namespace LMS_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Bl_ManageLoan lms_Bl = new Bl_ManageLoan();
            List<ApplyLoan> list = lms_Bl.ShowManageLoan();
            dataGrid1.ItemsSource = list;
        }


        private void btn_AcceptLoan_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AcceptLoan al = new AcceptLoan();
            al.Show();
        }

        private void btn_RejectLoan_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            RejectLoan rl = new RejectLoan();
            rl.Show();
        }

        private void btn_ShowLoanApplications_Click(object sender, RoutedEventArgs e)
        {
            Bl_ManageLoan lms_Bl = new Bl_ManageLoan();
            //lms_Bl.InsertManageLoan();
            List<ApplyLoan> list = lms_Bl.ShowAllLoanApplications();
            dataGrid.ItemsSource = list;
        }

        private void btn_Back_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Employee_Operations EO = new Employee_Operations();
            EO.Show();
        }
    }
}
