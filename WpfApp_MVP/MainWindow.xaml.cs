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
using WpfApp_MVP.View;
using WpfApp_MVP.Presenter;

namespace WpfApp_MVP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, ILogin
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public string Username
        {
            get
            {
                return textBox_username.Text;
            }
            set
            {
                textBox_username.Text = value;
            }
        }

        public string Password
        {
            get
            {
                return textBox_password.Text;
            }
            set
            {
                textBox_password.Text = value;
            }
          
        }

        public string Onay_Durum
        {
            get
            {
                return textBox_Sonuc.Text;
            }
            set
            {
                textBox_Sonuc.Text = value;
            }
        }

        private void Button_login_Click(object sender, RoutedEventArgs e)
        {
            LoginPresenter loginPresenter = new LoginPresenter(this);
            loginPresenter.LoginKontrol();
        }
    }
}
