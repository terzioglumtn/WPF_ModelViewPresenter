using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp_MVP.Model; 
using WpfApp_MVP.View; 

namespace WpfApp_MVP.Presenter
{
    public class LoginPresenter
    {
        ILogin loginView;
        LoginModel login = new LoginModel();

        public LoginPresenter(ILogin view)
        {
            loginView = view;
        }

        public void LoginKontrol()
        {
            login.Username          = loginView.Username;
            login.Password          = loginView.Password;
            loginView.Onay_Durum    = login.Kontrol();
        }
    }
}
