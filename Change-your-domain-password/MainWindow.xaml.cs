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

namespace Change_your_domain_password
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public string OldPassword { get; set; }
        public string NewPassword { get; set; } 

        public string DomainName { get; }

        public string UserName { get;  }

        public MainWindow()
        {
            InitializeComponent();

            LoadInfo();


        }

       public void LoadInfo()
        {
            try
            {
                LB_DomainName.Content = Environment.UserDomainName;
                LB_UserName.Content = Environment.UserName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString(), "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                throw;
            }
        }

        private void BT_ChangePassword_Click(object sender, RoutedEventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
