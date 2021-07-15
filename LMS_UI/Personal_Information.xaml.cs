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
using LMS_BL;
using LMS_ENTITY;
using LMS_EXCEPTION;

namespace LMS_UI
{
    /// <summary>
    /// Interaction logic for Personal_Information.xaml
    /// </summary>
    public partial class Personal_Information : Window
    {
        public Personal_Information()
        {
            InitializeComponent();
        }

        private void Button_Click_Update(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Update_Customer_Details UCD = new Update_Customer_Details();
            UCD.Show();
        }

        private void Button_Click_View(object sender, RoutedEventArgs e)
        {
            this.Hide();
            View_Customer_Details VCD = new View_Customer_Details();
            VCD.Show();
        }

        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            this.Hide();
            MainWindow1 MW1 = new MainWindow1();
            MW1.Show();
        }
    }
}
