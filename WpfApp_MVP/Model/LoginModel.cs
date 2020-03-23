using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp_MVP.Model
{
    public class LoginModel
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public string Onay_Durum { get; set; }

        public string Kontrol ()
        {
            if (Username == "metin")
            {
                if (Password == "1234")
                {
                    Onay_Durum = "ONAYLANDI, BASARILI";
                }
                else
                {
                    Onay_Durum = "ONAYLANMASI, SIFRE YANLIS";
                }
            }
            else
            {
                Onay_Durum = "ONAYLANMADI, KULLANICI ADI YANLIS";
            }

            return Onay_Durum;
        }
    }
}
