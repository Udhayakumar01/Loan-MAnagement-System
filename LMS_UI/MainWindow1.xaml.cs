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

namespace LMS_UI
{
    /// <summary>
    /// Interaction logic for MainWindow1.xaml
    /// </summary>
    public partial class MainWindow1 : Window
    {
        public MainWindow1()
        {
            InitializeComponent();
        }

       


        private void Button_Click_Personal_Info(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Personal_Information PI = new Personal_Information();
            PI.Show();
        }

        private void Button_Click_Loan_Status(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Loan_Status LS = new Loan_Status();
            LS.Show();
        }

        private void Button_Click_Apply_Loan(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Apply_Loan AL = new Apply_Loan();
            AL.Show();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Customer_Login CL = new Customer_Login();
            CL.Show();
        }
    }
}
